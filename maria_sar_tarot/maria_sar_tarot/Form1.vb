Public Class Form1
    Public Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Dim x As New List(Of Image) From {My.Resources.love, My.Resources.death, My.Resources.libra, My.Resources.fool, My.Resources.luck, My.Resources.devil, My.Resources.magician, My.Resources.varakia}


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tuxaio As Random = New Random
        Dim arithmos As Integer
        arithmos = tuxaio.Next(1, 8)
        Dim number As Integer
        number = tuxaio.Next(1, 8)

        If arithmos = 1 And number = 1 Then
            PictureBox1.Image = My.Resources.love
            PictureBox2.Image = My.Resources.love
            TextBox1.Text = "Η τέλεια μέρα για να βγεις απ το σπίτι! Μια ξεχωριστή μέρα για σένα, εφόσον η μοίρα σου επιφυλάσσει να γνωρίσεις τον έρωτα της ζωής σου."
        End If

        If arithmos = 1 And number = 2 Then
            PictureBox1.Image = My.Resources.love
            PictureBox2.Image = My.Resources.death
            TextBox1.Text = "Ένα ξεχωριστό πρόσωπο της ζωής σου θα χαθεί από ένα τροχαίο δυστύχημα σε σύντομο χρονικό διάστημα. Έχε τον νου σου"
        End If

        If arithmos = 1 And number = 3 Then
            PictureBox1.Image = My.Resources.love
            PictureBox2.Image = My.Resources.luck
            TextBox1.Text = "Τι τύχη για σένα! Θα γνωρίσεις ένα ξεχωριστό πρόσωπο, το οποίο θα βγάλεις δύσκολα απ το μυαλό σου. Κεραυνοβόλος έρωτας!"
        End If

        If arithmos = 1 And number = 4 Then
            PictureBox1.Image = My.Resources.love
            PictureBox2.Image = My.Resources.magician
            TextBox1.Text = "Μην εμπιστευεσαι εύκολα. Το ταίρι σου δεν είναι αυτό που φαίνεται. Κρύβει μυστικά, τα οποία ίσως σε πληγώσουν στο μέλλον! Έχε τον νου σου!"
        End If
        If arithmos = 1 And number = 5 Then
            PictureBox1.Image = My.Resources.love
            PictureBox2.Image = My.Resources.fool
            TextBox1.Text = "Πετριγυρίζεσαι από ηλίθιους! Ίσως κάποιος απ αυτούς προσπαθεί να μπει στα ερωτικά σου αλλά μην φοβάσαι, γιατί έχεις ήδη μια καλά κτισμένη σχέση με το ταίρι σου!"
        End If

        If arithmos = 1 And number = 6 Then
            PictureBox1.Image = My.Resources.love
            PictureBox2.Image = My.Resources.varakia
            TextBox1.Text = "Η σχέση με το ταίρι σου δεν βρίσκεται σε καλό δρόμο. Καλό είναι να βρεις την δύναμη να μπορέσεις να αποχωρήσεις απ αυτήν χωρίς να πληγωθείς αλλά και να πληγώσεις! "
        End If

        If arithmos = 1 And number = 7 Then
            PictureBox1.Image = My.Resources.love
            PictureBox2.Image = My.Resources.devil
            TextBox1.Text = "Πρόσεχε γιατί το άτομο που αγαπάς έχει σατανιστικές πεποιθήσεις, ίσως σε μπλέξει και σένα σε όλο αυτό. Καλύτερα να κρατήσεις αποστάσεις όσο ακόμα προλαβαίνεις!"
        End If
        If arithmos = 1 And number = 8 Then
            PictureBox1.Image = My.Resources.love
            PictureBox2.Image = My.Resources.libra
            TextBox1.Text = "Έχεις μια πολύ καλή ισορροπημένη σχέση με το ταίρι σου, keep it up!!!"
        End If

        If arithmos = 2 And number = 2 Then
            PictureBox1.Image = My.Resources.death
            PictureBox2.Image = My.Resources.death
            TextBox1.Text = "Οι μέρες σου είναι μετρημένες. Καλό είναι να προσέχεις αυτό το διάστημα στις εξόδους σου!"
        End If

        If arithmos = 2 And number = 3 Then
            PictureBox1.Image = My.Resources.death
            PictureBox2.Image = My.Resources.luck
            TextBox1.Text = "Θα πεθάνει ένα αγαπημένο σου πρόσωπο αλλά τουλάχιστον θα κληρονομήσεις την περιουσία του!!"
        End If

        If arithmos = 2 And number = 4 Then
            PictureBox1.Image = My.Resources.death
            PictureBox2.Image = My.Resources.magician
            TextBox1.Text = "Κάποιο κοντινό σου άτομο σχεδιάζει τον θάνατό σου. Έχε τον νου σου!! "
        End If

        If arithmos = 2 And number = 5 Then
            PictureBox1.Image = My.Resources.death
            PictureBox2.Image = My.Resources.fool
            TextBox1.Text = "Μην λειτουργείς σπασμωδικά, γιατί καραδοκεί ο θάνατος! Έχε τον νου σου!"
        End If

        If arithmos = 2 And number = 6 Then
            PictureBox1.Image = My.Resources.death
            PictureBox2.Image = My.Resources.varakia
            TextBox1.Text = "Πάσχεις από μια σοβαρή ασθένια αλλά μην σε τρομάζει αυτό, έχεις την δύναμη να το καταπολεμήσεις και έχεις δίπλα σου ανθρώπους που σε αγαπάνε!"
        End If

        If arithmos = 2 And number = 7 Then
            PictureBox1.Image = My.Resources.death
            PictureBox2.Image = My.Resources.devil
            TextBox1.Text = "Θα πεθάνεις στον ύπνο σου και θα πας στην κόλαση! Deal with it"
        End If

        If arithmos = 2 And number = 8 Then
            PictureBox1.Image = My.Resources.death
            PictureBox2.Image = My.Resources.libra
            TextBox1.Text = "Πεθαίνεις δεν πεθαίνεις!!! Deal with it!!"
        End If

        If arithmos = 3 And number = 3 Then
            PictureBox1.Image = My.Resources.luck
            PictureBox2.Image = My.Resources.luck
            TextBox1.Text = "Κερδίζεις το τζόκερ και πας ταξίδι στην Σελήνη και βρίσκεις έναν σπάνιο πολύτιμο λίθο που θα σε κάνει Μεγαλοκαρχαρία! "
        End If

        If arithmos = 3 And number = 4 Then
            PictureBox1.Image = My.Resources.luck
            PictureBox2.Image = My.Resources.magician
            TextBox1.Text = "Η τύχη είναι με το μέρος σου, και αποκτάς μαγικές ικανότητες!"
        End If

        If arithmos = 3 And number = 5 Then
            PictureBox1.Image = My.Resources.luck
            PictureBox2.Image = My.Resources.fool
            TextBox1.Text = "Η τύχη είναι με το μέρος σου, προσπάθησε να την χρησιμοποιήσεις προς όφελός σου και όχι να την σπαταλάς."
        End If

        If arithmos = 3 And number = 6 Then
            PictureBox1.Image = My.Resources.luck
            PictureBox2.Image = My.Resources.varakia
            TextBox1.Text = "Αν και η τύχη αυτό το διάστημα είναι με το μέρος σου, εσύ δεν έχεις την ψυχολογική δύναμη να την χρησιμοποιήσεις αποτελεσματικά."
        End If

        If arithmos = 3 And number = 7 Then
            PictureBox1.Image = My.Resources.luck
            PictureBox2.Image = My.Resources.devil
            TextBox1.Text = "Δεν θα σου πρότεινα πολλές εξόδους αυτό το διάστημα διότι η μοίρα σου παίζει άσχημα παιχνίδια."
        End If

        If arithmos = 3 And number = 8 Then
            PictureBox1.Image = My.Resources.luck
            PictureBox2.Image = My.Resources.libra
            TextBox1.Text = "Αν και τυχερός αυτό το διάστημα, μην αποδοκιμάζεις την τύχη σου. Keep calm!"
        End If

        If arithmos = 4 And number = 4 Then
            PictureBox1.Image = My.Resources.magician
            PictureBox2.Image = My.Resources.magician
            TextBox1.Text = "Τελευταία ασχολείσαι με μαγικές ιδιότητες, και η μοίρα σου επιφυλάσσει ένα καλό μέλλον ως μάγος. Ψάξ'το  "
        End If

        If arithmos = 4 And number = 5 Then
            PictureBox1.Image = My.Resources.magician
            PictureBox2.Image = My.Resources.fool
            TextBox1.Text = "Χαζές ιδέες σου ρχονται κατά νου, δεν πρόκειται να αποκτήσεις μαγικές ικανότητες, οπότε ξεπέρασε το!"
        End If

        If arithmos = 4 And number = 6 Then
            PictureBox1.Image = My.Resources.magician
            PictureBox2.Image = My.Resources.varakia
            TextBox1.Text = "Έχεις την υπομονή να ασχοληθείς με την μαγεία; Τώρα είναι η ευκαιρία!"
        End If

        If arithmos = 4 And number = 7 Then
            PictureBox1.Image = My.Resources.magician
            PictureBox2.Image = My.Resources.devil
            TextBox1.Text = "Θα γνωρίσεις κάποια άτομα που έχουν σατανιστικές ιδεολογίες και ασχολούνται με την μαύρη μαγεία, θες να γίνεις ένας απ αυτούς ή όχι; Στο χέρι σου είναι! "
        End If

        If arithmos = 4 And number = 8 Then
            PictureBox1.Image = My.Resources.magician
            PictureBox2.Image = My.Resources.libra
            TextBox1.Text = "Το χεις δεν το χεις με την μαγεία, αλλά αν βλέπεις ότι δεεεεν.. μην το παιδεύεις και πολύ!!"
        End If

        If arithmos = 5 And number = 5 Then
            PictureBox1.Image = My.Resources.fool
            PictureBox2.Image = My.Resources.fool
            TextBox1.Text = "Όταν περιτρυγιρίζεσαι από ανόητους, επόμενο κάποια στιγμή να γίνεις ένας απ αυτούς!!"
        End If

        If arithmos = 5 And number = 6 Then
            PictureBox1.Image = My.Resources.fool
            PictureBox2.Image = My.Resources.varakia
            TextBox1.Text = "Έχεις την δύναμη να μείνεις μακριά από άτομα που θεωρείς ηλίθια. Μην ανησυχείς λοιπόν αν θα τα πληγώσεις, απλά φύγε από κοντά τους!"
        End If

        If arithmos = 5 And number = 7 Then
            PictureBox1.Image = My.Resources.fool
            PictureBox2.Image = My.Resources.devil
            TextBox1.Text = "Τελευταία βλέπεις πολλές ταινίες με διαβόλους, θα σουν ανόητος αν πίστευες σε αυτά."
        End If

        If arithmos = 5 And number = 8 Then
            PictureBox1.Image = My.Resources.fool
            PictureBox2.Image = My.Resources.libra
            TextBox1.Text = "Ισορροπημένη βλακεία στον εγκέφαλο σου που σε επηρεάζει σε σημαντικές αποφάσεις της ζωής σου!!"
        End If

        If arithmos = 6 And number = 6 Then
            PictureBox1.Image = My.Resources.varakia
            PictureBox2.Image = My.Resources.varakia
            TextBox1.Text = "Έχεις καταφέρει να είσαι και ψυχολογικά δυνατός αλλά και σωματικά. Good for U!"
        End If

        If arithmos = 6 And number = 7 Then
            PictureBox1.Image = My.Resources.varakia
            PictureBox2.Image = My.Resources.devil
            TextBox1.Text = "Υπάρχουν κοντινά άτομα στην ζωή σου που κοιτάζουν πως να σε ρίξουν και να σε βλάψουν, πρέπει να φανείς δυνατός!"
        End If

        If arithmos = 6 And number = 8 Then
            PictureBox1.Image = My.Resources.varakia
            PictureBox2.Image = My.Resources.libra
            TextBox1.Text = "Βρες την αρμονία στην ζωή σου, ξεκινώντας κάποια αγαπημένη σου δραστηριότητα"
        End If
        If arithmos = 7 And number = 7 Then
            PictureBox1.Image = My.Resources.devil
            PictureBox2.Image = My.Resources.devil
            TextBox1.Text = "Θα πληγωθείς πολύ από κάποιο κοντινό σου άτομο, το οποίο ίσως το θεωρούσες πολύ σημαντικό στην ζωή σου αλλά αυτό είχε άλλες βλέψεις για σένα. Θα ακολουθήσει μια περίοδος κατάθλιψης και στεναχώριας. Προσπάθησε να μείνεις δίπλα στα άτομα ππου σε αγαπάνε πραγματικά και απλά σταμάτα να εμπιστεύεσαι τόσο εύκολα αλλά ταυτόχρονα μην βιάζεσαι να βγάλεις και γρήγορα συμπεράσματα για κάποιον χωρίς να τον έχεις γνωρίσει! Ένα μάθημα ζωής για σένα!!"
        End If

        If arithmos = 7 And number = 8 Then
            PictureBox1.Image = My.Resources.devil
            PictureBox2.Image = My.Resources.libra
            TextBox1.Text = "Πολλές φορές γίνεσαι αγενής με δικά σου πρόσωπα, με αποτέλεσμα να τα πληγώνεις. Προσπάθησε να μετράς τα λόγια σου περισσότερο!! "
        End If

        If arithmos = 8 And number = 8 Then
            PictureBox1.Image = My.Resources.libra
            PictureBox2.Image = My.Resources.libra
            TextBox1.Text = "Είναι όλα καλά στην ζωή σου, μια αρκετά καλή περιόδος για σένα εφόσον τα έχεις βρει με τον εαυτό σου."
        End If



        ' PictureBox2.Image = My.Resources.love
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e _
As System.EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "Click here to get more info."
        LinkLabel1.Links.Add(6, 4, "www.myastro.gr")
    End Sub
    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        ' Display the date as "Mon 27 Feb 2012".
        DateTimePicker1.CustomFormat = "ddd dd MMM yyyy"
    End Sub

End Class
