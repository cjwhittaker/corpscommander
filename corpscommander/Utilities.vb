﻿Module Utilities
    Function d6()
        d6 = Int(6 * Rnd + 1)
    End Function
    Function daverage()
        Dim Dice As Integer = Int(6 * Rnd() + 1)
        If Dice = 1 Then Dice = 3
        If Dice = 6 Then Dice = 4
        daverage = Dice
    End Function
    Function d4()
        d4 = Int(4 * Rnd + 1)
    End Function
    Function d10()
        d10 = Int(10 * Rnd + 1)
    End Function
    Function d100()
        d100 = Int(100 * Rnd + 1)
    End Function
    Function d20()
        d20 = Int(20 * Rnd + 1)
    End Function

    Public Sub populate_lists(ByVal l As ListView, ByVal purpose As String, ByVal nation As String)
        Dim listitem As ListViewItem, j As Integer = 0, loaded As String = "*", info As String = ""
        'For Each i As ListViewItem In l.Items
        '    i.Remove()
        'Next
        l.Items.Clear()
        'l.BackColor = nostatus
        'If purpose = "Opportunity Fire" Then
        '    listitem = New ListViewItem
        '    listitem.Text = "Minefield"
        '    l.Items.Add(listitem)
        'End If
        For Each u As cequipment In eq_list
            If u.valid_equipment(nation, purpose) Then
                listitem = New ListViewItem
                listitem.Text = u.title
                listitem.SubItems.Add("")
                l.Items.Add(listitem)
                If u.weapon_2 <> "" Then
                    listitem = New ListViewItem
                    listitem.Text = u.title
                    listitem.SubItems.Add(u.weapon_2)
                    l.Items.Add(listitem)
                End If
            End If
        Next
    End Sub

    'Public Sub ewsupport(ByVal candidates As Collection, ByVal phase As String)
    '    Dim ewac As Boolean = False
    '    For Each subject As cunit In candidates
    '        If phase = "CAP" And subject.task = "EW Support" And subject.airborne Then
    '            ewac = True : Exit For
    '        ElseIf phase = "Air-Ground Attack" And subject.task = "SEAD" And subject.airborne Then
    '            ewac = True : Exit For
    '        Else

    '        End If
    '    Next
    '    For Each subject As cunit In candidates
    '        If (subject.aircraft And Not subject.heli) And subject.airborne Then subject.ewsupported = ewac Else subject.ewsupported = ewac
    '    Next
    'End Sub

    Public Sub resolvefire(ByVal firer As cunit, ByVal target As cunit, ByVal firephase As String)
        Dim unobserved As Boolean = False
        Dim airtoair As Boolean = False
        firer.phase = firephase
        If firer.phase = "Air-to-Air" Then airtoair = True
        'Dim spotrange As Integer
        firer.set_fire_parameters()
        target.set_fire_parameters()

        Dim tgtrange As Integer = Val(combat.tgt_range.Text)
        If target.firers > 0 Then
            target.fires = True
        Else
            target.fires = False
            target.msg = "No return fire from the target"
        End If
        firer.set_fire_effect(target, tgtrange, 0)
        If target.fires Then target.set_fire_effect(firer, tgtrange, 0) Else target.effect = 0

        If firer.effect > 0 And Not target.spotted And (firer.indirect Or firer.Airground) Then
            firer.effective = True
            If firer.role = "|RL|" Then unobserved = False Else unobserved = True
        ElseIf firer.effect > 0 Then
            firer.effective = True
            If firer.task = "AF" Then unobserved = True Else unobserved = False
        Else
            firer.effective = False
            firer.msg = " spotted their target but no effect firing"
        End If

        If target.fires And target.effect = 0 And firer.spotted Then
            target.msg = "spotted the firer but no effect firing"
            target.effective = False
        ElseIf target.fires And target.effect > 0 Then
            target.effective = True
        Else
        End If

        If Not firer.effective And Not target.effective Then
            If firephase = "Air Defence" Or target.heli Then
                If firer.effect = -1 Then
                    resultform.result.Text = "Air Defence unit cannot engage - Radar off"
                ElseIf firer.effect = -2 Then
                    resultform.result.Text = "Air unit is too high to engage"
                Else
                    resultform.result.Text = "Air Defence unit cannot engage - Radar off" + vbNewLine + "and air unit is too high to engage"
                End If
            ElseIf Not target.fires Then
                resultform.result.Text = "Firer has no effect"
            ElseIf target.fires Then
                resultform.result.Text = "Neither Firer or target has any effect on each other"
            Else
            End If
            resultform.ShowDialog()
            combat.Hide()
            Exit Sub
        End If

        Dim init_msg As String = ""
        'firer.fired = gt
        'If target.fires Then target.fired = gt

        If firephase = "CAP" Or firephase = "Intercept" Then
            init_msg = "Air-to-Air combat Result "
            For i As Integer = 1 To 3
                If firephase = "Intercept" And i = 1 Then i = 2
                firer.set_fire_effect(target, tgtrange, i)
                If firer.effect > 0 Then firer.result = firecasualties(firer, target, tgtrange, False)
                If firer.result < 0 Then target.aborts = target.aborts + 1 : target.hits = target.hits + 1 : firer.result = 0
                If firer.result > 0 Then target.casualties = target.casualties + firer.result : target.hits = target.hits + firer.result : firer.result = 0
                If target.fires Then
                    target.set_fire_effect(firer, tgtrange, i)
                    If target.effect > 0 Then target.result = firecasualties(target, firer, tgtrange, False)
                    If target.result < 0 Then firer.aborts = firer.aborts + 1 : firer.hits = firer.hits + 1 : target.result = 0
                    If target.result > 0 Then firer.casualties = firer.casualties + target.result : firer.hits = firer.hits + target.result : target.result = 0
                End If
            Next
            firer.msg = firer.equipment + " fired at " + target.equipment + generateresult(target, firer.result, False, airtoair, False)
            If target.fires Then target.msg = target.equipment + " fired at " + firer.equipment + generateresult(firer, target.result, False, airtoair, False)

        ElseIf firephase = "Air Defence" Or target.heli Then
            init_msg = "Air Defence Result "
            firer.result = firecasualties(firer, target, tgtrange, True)
            If firer.result < 0 Then target.aborts = target.aborts + 1 : target.hits = target.hits + 1 : firer.result = 0
            If firer.result > 0 Then target.casualties = target.casualties + firer.result : target.hits = target.hits + firer.result : firer.result = 0
            firer.msg = firer.equipment + " fired at " + target.equipment + generateresult(target, firer.result, False, True, False)
            'SEAD attack returns fire
            If target.fires And phase = 10 Then
                target.result = firecasualties(target, firer, tgtrange, False)
                target.msg = target.equipment + "(" + target.equipment + ")" + " fired at " + firer.equipment + generateresult(firer, target.result, False, False, False)
            End If
        ElseIf firephase = "SEAD" Then
            init_msg = "SEAD Attack Result "
            firer.result = firecasualties(firer, target, tgtrange, True)
            firer.msg = firer.equipment + " fired at " + target.equipment + generateresult(target, firer.result, firer.indirect, False, False)
        ElseIf firer.indirect Or firer.Airground Then
            If firer.indirect And unobserved Then
                init_msg = "Unobserved Indirect Fire "
            ElseIf firer.indirect And Not unobserved Then
                init_msg = "Observed Indirect Fire"
            ElseIf firer.Airground Then
                init_msg = "Air-Ground Fire "
            End If
            firer.result = firecasualties(firer, target, tgtrange, unobserved)
            If firer.heavy_fire And firer.result <> 0 Then target.statusimpact = 1
            firer.msg = firer.equipment + " fired at " + target.equipment + generateresult(target, firer.result, True, False, False)
        ElseIf oppfire Then
            init_msg = "Opportunity Fire "
            If oppfire Then init_msg = firer.equipment + " conducts opportunity fire against " + target.equipment
            firer.result = firecasualties(firer, target, tgtrange, unobserved)
            firer.msg = target.equipment + " " + generateresult(target, firer.result, firer.indirect, airtoair, False)
            target.msg = ""
        Else
            init_msg = "Simultaneous firefight "
            If firer.effective Then firer.result = firecasualties(firer, target, tgtrange, unobserved)
            If target.fires And target.effective Then target.result = firecasualties(target, firer, tgtrange, unobserved)
            firer.msg = firer.equipment + " fired at " + target.equipment + generateresult(target, firer.result, firer.indirect, airtoair, False)
            If target.fires And target.effective Then
                target.msg = target.equipment + " fired at " + firer.equipment + generateresult(firer, target.result, False, airtoair, False)
            End If
        End If
        result_option = ""
        With resultform
            .result.Text = "Results" + vbNewLine + init_msg + vbNewLine + firer.msg + vbNewLine + target.msg
            .Tag = "firing"
            .ok_button.Visible = True
            .yb.Visible = IIf(InStr(target.msg, "disperse") > 0, True, False)
            .yb.Text = "Disperse " + firer.equipment
            .hvy1.Visible = True
            .hvy1.Text = "Hvy Loss " + firer.equipment
            .hvy1.BackColor = IIf((firer.hits = 4 And firer.mode = disp) Or firer.hits > 4, golden, defa)
            .hvy1.Enabled = IIf(.hvy1.BackColor = golden, False, True)
            .nb.Visible = IIf(InStr(firer.msg, "disperse") > 0, True, False)
            .nb.Text = "Disperse " + target.equipment
            .hvy2.Visible = True
            .hvy2.Text = "Hvy Loss" + target.equipment
            .hvy2.BackColor = IIf((target.hits = 4 And target.mode = disp) Or target.hits > 4, golden, defa)
            .hvy2.Enabled = IIf(.hvy2.BackColor = golden, False, True)
            .ShowDialog()
            .yb.Text = "Yes"
            .nb.Text = "No"
            .yb.Visible = False
            .nb.Visible = False
        End With
        If (firer.hits = 4 And firer.mode = conc And InStr(result_option, "Hvy Loss " + firer.equipment) = 0) _
            Or (firer.hits = 4 And firer.mode = disp) Or firer.hits > 4 _
            Or (InStr(result_option, "Hvy Loss " + firer.equipment) > 0) Then
            With morale_test
                .tester = firer
                .immediate = True
                .rallying = False
                .ShowDialog()
            End With
        End If
        If (target.hits = 4 And target.mode = conc And InStr(result_option, "Hvy Loss " + target.equipment) = 0) _
            Or (target.hits = 4 And target.mode = disp) Or target.hits > 4 _
            Or (InStr(result_option, "Hvy Loss " + target.equipment) > 0) Then
            With morale_test
                .tester = target
                .immediate = True
                .ShowDialog()
            End With
        End If

        'If firer.result < 0 Then firer.result = 1
        'If target.result < 0 Then target.result = 1
        'If InStr(firer.msg, "disperse") > 0 And InStr(result_option, "Disperse nph") > 0 Then
        '    target.casualties = target.casualties + firer.result - 1
        '    target.mode = disp
        'End If
        'If InStr(target.msg, "disperse") > 0 And InStr(result_option, "Disperse ph") > 0 Then
        '    firer.casualties = firer.casualties + target.result - 1
        '    firer.mode = disp
        'End If
        'If InStr(firer.msg, "disperse") > 0 And InStr(result_option, "Disperse nph") = 0 Then target.casualties = target.casualties + firer.result
        'If InStr(target.msg, "disperse") > 0 And InStr(result_option, "Disperse ph") = 0 Then firer.casualties = firer.casualties + target.result

        'If firephase = "Air Defence" Or firephase = "CAP" Or (firephase = "Fire and Movement" And target.heli) Then
        '    If target.hit And target.disrupted Then target.lands(False)
        'ElseIf firephase = "Air Ground" Then
        '    If target.hit And target.disrupted Then check_demoralisation(targets, target.parent, target.quality)
        'ElseIf firephase = "Opportunity Fire" Then
        '    If target.hit And (target.disrupted Or target.strength <= 0) Then check_demoralisation(targets, target.parent, target.quality)
        'ElseIf firephase = "Fire and Movement" Then
        '    If target.hit And (target.disrupted Or target.strength <= 0) Then check_demoralisation(targets, target.parent, target.quality)
        '    If firer.hit And (firer.disrupted Or firer.strength <= 0) Then check_demoralisation(firers, firer.parent, firer.quality)
        'Else
        'End If

    End Sub
    Function spotting(range As Integer, spotter As cunit, target As cunit)
        spotting = False
        If target Is Nothing Or target.equipment = "" Then Exit Function
        If spotter.indirect Then
            If spotter.Cover > 0 And target.Cover > 0 And range <= 300 Then
                spotting = True
                Exit Function
            End If
        End If
        Dim obr As Integer, om As Integer
        obr = 100 * eq_list(target.equipment).bor
        If spotter.task = "FFE" Then
            obr = 1200
        ElseIf target.mode = travel Then
            obr = 1000
        ElseIf target.Inf And target.dismounted Then
            If target.mode = disp Then
                obr = 100
            ElseIf target.mode = conc Then
                obr = 200
            Else
            End If
        ElseIf target.mode = disp And obr = 800 Then
            obr = 600
        Else
        End If

        Dim smoked As Boolean = IIf(combat.tinsmoke.BackColor = golden Or combat.finsmoke.BackColor = golden, True, False)
        If night Then
            om = 1
        ElseIf twilight Then
            om = 3
        Else
            om = 4
        End If
        If InStr(LCase(eq_list(spotter.equipment).special), "t") > 0 Then
            If night Or smoked Or twilight Then om = 3
        ElseIf InStr(LCase(eq_list(spotter.equipment).special), "i") > 0 Then
            If night Then om = 2
        Else
        End If
        If smoked And InStr(LCase(eq_list(spotter.equipment).special), "t") = 0 Then om = om - 4
        If spotter.elevated Then om = om + 1
        If spotter.moved Then om = om - 1
        If spotter.mode = travel Then om = om - 1
        If spotter.task <> "FFE" Then
            If target.fired Then om = om + 2
            If target.moved Then om = om + 1
            If target.roadmove And Not target.mode = disp Then om = om + 1
            If target.plains Then om = om + 1
        End If
        'If target.mode = disp Then om = om - 1
        om = om - target.Cover
        If om <= 0 And night Then
            om = 0
        ElseIf om <= 0 Then
            om = 1
        ElseIf om > 9 Then
            om = 9
        Else
        End If
        If range <= obr * om Then spotting = True
    End Function

    Function firecasualties(ByVal firer As cunit, ByVal target As cunit, ByVal rng As Integer, ByVal unobserved As Boolean)
        firecasualties = 0
        Dim airtoair As Boolean = firer.airborne And target.airborne
        Dim airdefence As Boolean = firer.airdefence And target.airborne
        Dim directfire As Boolean = IIf(firer.phase = "Direct Fire", True, False)
        Dim indirectfire As Boolean = IIf(firer.phase = "Indirect Fire", True, False)

        Dim modifiers As Integer = 0, col As Integer = 0, row As Integer = 0, dice As Integer = 0, fv As Integer = 0, fire_effect As Integer = 0, fire_strength As Integer = 0
        Dim airground As Boolean = firer.Airground
        Dim defence As Integer = 0

        If firer.effect = 0 Then firecasualties = 0 : Exit Function
        If airtoair Then
            defence = eq_list(target.equipment).defence
        ElseIf airdefence Then
            If eq_list(firer.equipment).role = "|AAA|" Then defence = eq_list(target.equipment).gun_def Else defence = eq_list(target.equipment).miss_def
        Else
            defence = eq_list(target.equipment).defence
        End If
        If firer.phase = "SEAD" Then
            directfire = True
            modifiers = modifiers - target.modifier
        End If
        If airtoair Then
            If firer.task = "CAP" And target.task <> "CAP" Then modifiers = modifiers + 2
            If target.ewsupported Then modifiers = modifiers - 2
        End If
        If airdefence Then
            If target.ewsupported Then modifiers = modifiers - 2
            modifiers = modifiers + firer.modifier
        End If
        If target.heli Then
            If target.mode = "Very Low" And Not firer.eligibleCB Then
                modifiers = modifiers - 1
            ElseIf target.mode = "Very Low" And firer.eligibleCB Then
                modifiers = modifiers - 6
            ElseIf target.mode = "Low" And firer.eligibleCB Then
                modifiers = modifiers - 4
            Else
            End If
        End If
        If directfire Then
            If target.armour And (target.mode = conc Or target.mode = travel) And (target.flanked Or target.rear) Then modifiers = modifiers + 2
            If target.armour And target.mode = disp And (target.flanked Or target.rear) Then modifiers = modifiers + 1
            If oppfire And (target.smoke_discharger Or target.smoke_generator) Then modifiers = modifiers - 1
            If oppfire And target.smoke_discharger Then modifiers = modifiers - 1
            modifiers = modifiers + target.size
            If firer.heat And target.composite Then modifiers = modifiers - 2
            If firer.heat And target.spaced Then modifiers = modifiers - 1
            If firer.mode = travel Then firer.firers = 1
            If combat.firingmode.Text = "Half Fire" And firer.stabilised Then modifiers = modifiers - 1
            If combat.firingmode.Text = "Half Fire" And Not firer.stabilised Then modifiers = modifiers - 2
            If target.mode <> disp And target.plains Then modifiers = modifiers + 2
        End If
        If indirectfire Then
            If firer.moved Then modifiers = modifiers - 1
            If firer.bomblets Then modifiers = modifiers + 2
            If unobserved Then modifiers = modifiers - 2
            If target.mode <> disp And target.plains Then modifiers = modifiers + 1
        End If
        If indirectfire Or directfire Then
            If target.mode = travel And Not target.recon Then modifiers = modifiers + 2
            If target.soft_tpt Then modifiers = modifiers + 2
            If target.mode = disp Then modifiers = modifiers - target.Cover
            If firer.insmoke Then modifiers = modifiers - 2
            If target.insmoke Then modifiers = modifiers - 2
            If firer.conc And firer.mode = disp Then modifiers = modifiers - 2
        End If
        If airdefence Or directfire Or airtoair Then
            Dim fs As Integer = firer.firers
            Do
                dice = d10() - 1
                For i As Integer = 0 To 11
                    If direct_fire(defence, i) >= firer.effect Then
                        col = i
                        Exit For
                    End If
                    If i = 11 Then col = i
                Next
                col = col + modifiers
                col = IIf(col < 0, 0, col)
                If firer.quality >= 8 Then dice = dice + 1
                If firer.quality <= 3 Then dice = dice - 1
                dice = dice + IIf(col > 11, col - 11, 0) + firer.fatigue
                dice = IIf(dice < 0, 0, dice)
                dice = IIf(dice > 9, 9, dice)
                col = IIf(col > 11, 11, col)
                fire_strength = IIf(fs > 9, 9, fs)
                fv = direct_fire_strength(fire_strength, col) - 1
                If fv <= 0 Then firecasualties = 0 : Exit Function
                firecasualties = firecasualties + fire_loss_table(dice, IIf(fv > 19, 19, fv))
                fs = fs - 9
            Loop Until fs <= 0
        ElseIf indirectfire Then
            Do
                dice = d10() - 1
                fire_effect = IIf(firer.effect > 10, 10, firer.effect)
                For row = 0 To 4
                    If row = 4 Or defence <= indirect_fire(row, 0) Then Exit For
                Next
                For col = 0 To 11
                    If firer.effect <= indirect_fire(row, col) Then Exit For
                Next
                col = col + modifiers
                col = IIf(col < 0, 0, col)
                dice = dice + IIf(col > 11, col - 11, 0) + firer.fatigue
                If firer.quality >= 8 Then dice = dice + 1
                If firer.quality <= 3 Then dice = dice - 1
                dice = IIf(dice < 0, 0, dice)
                dice = IIf(dice > 9, 9, dice)
                col = (IIf(col > 11, 11, col))
                fv = indirect_fire_strength(firer.firers, col) - 1
                firecasualties = firecasualties + fire_loss_table(dice, IIf(fv > 19, 19, fv))
                firer.effect = firer.effect - 10
            Loop Until firer.effect <= 0
        Else
        End If
    End Function

    Function generateresult(ByVal target As cunit, ByVal c As Integer, ByVal indirect As Boolean, airtoair As Boolean, ByVal assault As Boolean)
        target.hits = 0
        generateresult = ""
        If target.mode = travel And Not target.recon Then
            If c = -1 Then
                c = 1
            ElseIf c > 0 Then
                c = c + 1
            Else
            End If
        End If
        If airtoair Then
            If target.hits >= target.strength Then
                If target.casualties >= target.strength Then target.casualties = target.strength : target.aborts = 0
                If target.casualties < target.strength And target.aborts > 0 And target.casualties + target.aborts > target.strength Then target.aborts = target.strength - target.casualties
            End If
            generateresult = " with " + Str(target.casualties) + " aircraft shot down, with " + Str(target.aborts) + " aircraft aborted"
        ElseIf assault Then
            If Not (target.assault Or target.support) And target.strength > 0 Then
                generateresult = " disrupted, and suffered  " + Str(target.casualties) + " casualties, and must retreat 600m"
            ElseIf Not (target.assault Or target.support) And target.strength = 0 Then
                generateresult = " eliminated  "
            Else
                generateresult = " disrupted, and suffered  " + Str(target.casualties) + " casualties, and holds its current position"
            End If
        ElseIf c = 0 Then
            generateresult = " with no effect"
            'ElseIf target.airborne And c < 0 Then
            '    generateresult = " with an aircraft aborted"
            '    target.aborts = target.aborts + c
            'ElseIf target.airborne Then
            '    generateresult = " with " + Str(c) + " aircraft shot down"
            '    target.casualties = target.casualties + c
        ElseIf (target.mode = disp And c < 0) Then
            generateresult = " with no effect"
            target.hits = 0
        ElseIf target.mode = disp Then
            generateresult = " with" + Str(c) + IIf(c = 1, " casualty", " casualties")
            If c >= 2 Then target.disordered = True
            target.casualties = target.casualties + c
            target.hits = target.hits + c
        ElseIf target.mode <> disp And c < 0 Then
            generateresult = " with no casualties but which must disperse or accept 1 casualty"
            target.hits = 1
        Else
            generateresult = " with" + Str(c) + IIf(c = 1, " casualty", " casualties") + " which may now disperse"
            target.hits = target.hits + c
        End If
    End Function

    Public Sub applyresult(ByVal subject As cunit)
        Dim msg As String = ""
        If (subject.strength - subject.casualties <= 0) Then
            msg = subject.equipment + " has been destroyed"
            With subject
                .strength = 0
                .casualties = 0
                .hits = 0
            End With
        Else
            msg = ""
            If subject.casualties > 2 Or subject.hits >= 4 Or subject.statusimpact = 1 Then

                With morale_test
                    .Tag = "Immediate"
                    .tester = subject
                    .ShowDialog()
                    .Tag = ""
                End With
            End If
            With subject
                .strength = subject.strength - subject.casualties
                .casualties = 0
                .statusimpact = 0
            End With
        End If
        If msg <> "" Then
            With resultform
                .result.Text = msg
                .ShowDialog()
            End With
        End If
    End Sub

    Public Sub check_demoralisation(ByVal candidates As Collection, ByVal x As String, ByVal y As String)
        'Randomize()
        'Dim disrupted As Integer = 0, disordered As Integer = 0, destroyed As Integer = 0, totalunits As Integer = 0
        'For Each temp As cunit In candidates
        '    If temp.parent = x And temp.comd = 0 Then
        '        totalunits = totalunits + temp.initial
        '        destroyed = destroyed + (temp.initial - temp.strength)
        '        If temp.disrupted Then
        '            disrupted = disrupted + temp.strength
        '        ElseIf temp.disordered Then
        '            disordered = disordered + temp.strength
        '            'ElseIf temp.pinned Then
        '            '    pinned = pinned + temp.strength
        '        Else
        '        End If
        '    End If
        'Next
        'Dim percentdisrupted As Single = (disrupted + destroyed) / totalunits
        'Dim percentdisrupteddisordered As Single = (disrupted + disordered + destroyed) / totalunits
        'Dim d As Integer = d10()
        'If d > y And (percentdisrupted >= 0.333 Or percentdisrupteddisordered >= 0.5) Then
        '    With resultform
        '        .result.Text = parent(candidates, x)
        '        .ShowDialog()
        '    End With
        'End If
    End Sub
    'Public Function parent(ByVal candidates As Collection, ByVal x As String)
    '    parent = ""
    '    Dim fail_text As String = ""
    '    With orbat(x)
    '        .demoralised = True
    '        .moved = gt
    '    End With
    '    For Each temp As cunit In candidates
    '        If temp.parent = x Then
    '            temp.demoralised = True
    '            temp.moved = gt
    '            parent = parent + temp.equipment + ", "
    '        End If
    '    Next
    '    fail_text = " are now demoralised and on table units must move a minimum of half a tactical"
    '    fail_text = fail_text + vbNewLine + "move per turn toward their own sides baseline. The units of this BG"
    '    fail_text = fail_text + vbNewLine + "may not initiate fire"
    '    parent = parent + vbNewLine + fail_text
    'End Function
    Public Sub log_entry(ByVal result As String)
        'logtime = to_hr(x)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Strings.Left(scenario, (Len(scenario) - 4)) + ".his", True)
        file.WriteLine(result)
        file.Close()
    End Sub

    Public Function coc(ByVal title As String, ByVal hq As cunit, ByVal comd As Integer)
        If title = hq.equipment And comd = 0 Then
            coc = True
            Exit Function
        End If
        If hq.parent = "root" Then
            coc = False
            Exit Function
        End If


        coc = coc(title, orbat(hq.parent), comd)
    End Function


    Public Sub swap_phasing_player(exec As Boolean)
        Dim tmp As String
        If exec Then
            tmp = ph
            ph = nph
            nph = tmp
        End If
        If ph = scenariodefaults.player1.Text Then
            ph_hqs = New Collection
            ph_hqs = p1_hqs
            ph_units = New Collection
            ph_units = p1_units
            enemy = New Collection
            enemy = p2_Units
        Else
            ph_hqs = New Collection
            ph_hqs = p2_HQs
            ph_units = New Collection
            ph_units = p2_Units
            enemy = New Collection
            enemy = p1_units
        End If
    End Sub

    'Public Sub check_observer(firer As cunit)
    '    populate_lists(unit_selection.units, ph_units, "Observer", IIf(firer.primary <> "", firer.primary, firer.parent))
    '    With unit_selection
    '        .Tag = "Observer"
    '        .ShowDialog()
    '    End With
    'End Sub

    Public Sub populate_command_structure(tree As TreeView, ByVal side As String, purpose As String)
        Dim TopNode As TreeNode, u As New cunit, x As Integer = 0
        For Each u In orbat
            If u.root And u.nation = side Then Exit For
        Next
        tree.Nodes.Clear()
        TopNode = tree.Nodes.Add(u.equipment, u.equipment)
        CreateNodes(side, TopNode, u.equipment, purpose)
        tree.ExpandAll()
        tree.SelectedNode = TopNode

        'selectunit(orbat(tree.SelectedNode.Text))
    End Sub
    Public Sub CreateNodes(ByRef side As String, ByRef ParentNode As TreeNode, ByRef currentcomd As String, ByRef purpose As String)
        Dim subNode As New TreeNode
        For x As Integer = 1 To orbat.Count
            If orbat(x).nation = side Then

                If orbat(x).parent = currentcomd And orbat(x).comd < 6 Then
                    If (orbat(x).comd = 0 And purpose = "Orbat") Or orbat(x).comd > 0 Then
                        subNode = ParentNode.Nodes.Add(orbat(x).Title, orbat(x).Title)
                        subNode.BackColor = orbat(x).status(purpose)
                        If orbat(x).comd = 0 And purpose = "Orbat" And orbat(x).inf Then
                            If orbat(x).debussed And orbat(x).loaded = "" Then
                                subNode.ToolTipText = "Dismounted"
                            ElseIf orbat(x).debussed And orbat(x).loaded <> "" Then
                                subNode.ToolTipText = "Debussed"
                            ElseIf Not orbat(x).debussed Then
                                subNode.ToolTipText = "Embused"
                            Else
                            End If
                        End If
                    End If
                    If (purpose = "Orbat") Or (purpose = "Command" And orbat(x).comd > 1) Then CreateNodes(side, subNode, orbat(x).equipment, purpose)
                End If
            End If
        Next
    End Sub

    'Public Sub test_for_events(ByVal s As String, ByVal t As Date)
    '    For Each e As cevents In event_list
    '        If Not e.tested Then
    '            If Format(t, "HH:mm") >= e.time And s = e.side Then
    '                If e.die = "None" Then
    '                    e.tested = True
    '                Else
    '                    Dim dice6 As Integer = d6(), dice10 As Integer = d10()
    '                    If (e.die = "D6" And dice6 >= e.score) Or (e.die = "D10" And dice10 >= e.score) Then
    '                        e.tested = True
    '                    Else
    '                        If e.dec Then e.score = e.score - 1
    '                    End If
    '                End If
    '                If e.tested Then
    '                    With resultform
    '                        .Text = "Game Events - GT" + Trim(Str(gt)) + " at " + Format(t, "HH:mm") + "hrs"
    '                        .result.Text = e.unit + " " + e.text
    '                        .yb.Visible = False
    '                        .nb.Visible = False
    '                        .ok_button.Visible = True
    '                        .ShowDialog()
    '                        .nb.Visible = False
    '                    End With
    '                    For Each u As cunit In orbat
    '                        If u.nation = e.side And (u.equipment = e.unit Or u.parent = e.unit) Then
    '                            u.arrives = ""
    '                            If u.comd = 0 Then
    '                                If u.not_conc Then u.mode = travel
    '                            End If
    '                        End If
    '                    Next
    '                End If
    '            End If
    '        End If
    '    Next
    'End Sub

End Module
