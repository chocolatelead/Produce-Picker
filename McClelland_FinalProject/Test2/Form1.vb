
Public Class MyApplication
    'Public variables that change when a certain button is pressed'
    Dim total As Double = 0
    Dim Wallet As Double = 0
    Dim counter1 As Integer = 0
    Dim counter2 As Integer = 0
    Dim counter3 As Integer = 0
    Dim counter4 As Integer = 0
    Dim counter5 As Integer = 0
    Dim counter6 As Integer = 0
    Dim counter7 As Integer = 0
    Dim counter8 As Integer = 0
    Dim counter9 As Integer = 0
    Dim counter10 As Integer = 0
    Dim counter11 As Integer = 0
    Dim counter12 As Integer = 0
    Dim counter13 As Integer = 0
    Dim counter14 As Integer = 0
    Dim counter15 As Integer = 0
    Dim counter16 As Integer = 0
    Dim counter17 As Integer = 0
    Dim counter18 As Integer = 0
    Dim counter19 As Integer = 0
    Dim counter20 As Integer = 0


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This code prompts the user to put in a value in between 50 and 200, if the do not, it will keep popping up'
        Dim Input As String
        Do
            Input = InputBox("Enter the amount of money you want to spend between $50 and $200.", "Wallet Amount")
            Wallet = Val(Input)
        Loop Until Wallet <= 200 And Wallet >= 50



        lblWallet.Text = "Amount you are able to spend:   " & FormatCurrency(Wallet)

        'puts the panels in starting position.'
        Panel2.Hide()
        Panel1.Show()
        btnPagebackward.Enabled = False
        lblTitle.Text = "Fruits"

    End Sub
    Private Sub btnPagebackward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagebackward.Click
        'If user is at fruits, the button is disabled'
        If Panel1.Visible = True Then
            btnPagebackward.Enabled = False
            btnPageforward.Enabled = True
        End If
        'if user is at veggies, it sends them back to fruits and disables button'
        If Panel2.Visible = True Then
            btnPageforward.Enabled = True
            btnPagebackward.Enabled = False
            Panel2.SendToBack()
            Panel2.Hide()
            Panel1.BringToFront()
            Panel1.Show()
        End If
        lblTitle.Text = "Fruits"

    End Sub


    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPageforward.Click
        'This button sends the user to veggies and disables itself.'
        If Panel1.Visible = True Then
            btnPageforward.Enabled = False
            btnPagebackward.Enabled = True
            Panel1.SendToBack()
            Panel1.Hide()
            Panel2.BringToFront()
            Panel2.Show()

        End If
        lblTitle.Text = "Vegetables"
    End Sub
    ' http://www.vbforums.com/showthread.php?586396-2008-Add-Edit-Remove-Items-from-a-Listbox - where i figured out how to manipulate items in a listbox'


    Private Sub btnPeppers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeppers.Click
        Dim num As Integer = Val(nupPeppers.Text)
        Dim price As Double = 1.17 * num
        Dim ListItem As String = (num & " lb of Peppers - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter1 += 1

        If counter1 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnPeppers.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupPeppers_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupPeppers.ValueChanged
        btnPeppers.Enabled = True
    End Sub

    Private Sub btnLettuce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLettuce.Click
        Dim num As Integer = Val(nupLettuce.Text)
        Dim price As Double = 1.83 * num
        Dim ListItem As String = (num & " lb of Lettuce - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter2 += 1

        If counter2 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnLettuce.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupLettuce_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupLettuce.ValueChanged
        btnLettuce.Enabled = True
    End Sub
    Private Sub btnCarrot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarrot.Click
        Dim num As Integer = Val(nupCarrot.Text)
        Dim price As Double = 1.17 * num
        Dim ListItem As String = (num & " lb of Carrots - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter3 += 1

        If counter3 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnCarrot.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupCarrot_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupCarrot.ValueChanged
        btnCarrot.Enabled = True
    End Sub

    Private Sub btnCorn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorn.Click
        Dim num As Integer = Val(nupCorn.Text)
        Dim price As Double = 0.43 * num
        Dim ListItem As String = (num & " ears of Corn - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter4 += 1

        If counter4 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnCorn.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupCorn_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupCorn.ValueChanged
        btnCorn.Enabled = True
    End Sub
    Private Sub btnSprouts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSprouts.Click
        Dim num As Integer = Val(nupSprouts.Text)
        Dim price As Double = 1.17 * num
        Dim ListItem As String = (num & " lb of Brussel Sprouts - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter5 += 1

        If counter5 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnSprouts.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupSprouts_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupSprouts.ValueChanged
        btnSprouts.Enabled = True
    End Sub

    Private Sub btnAsparagus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsparagus.Click
        Dim num As Integer = Val(nupAsparagus.Text)
        Dim price As Double = 2.49 * num
        Dim ListItem As String = (num & " lb of Asparagus - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter6 += 1

        If counter6 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnAsparagus.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupAsparagus_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupAsparagus.ValueChanged
        btnAsparagus.Enabled = True
    End Sub
    Private Sub btnPotato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPotato.Click
        Dim num As Integer = Val(nupPotato.Text)
        Dim price As Double = 1.12 * num
        Dim ListItem As String = (num & " lb of Potatoes - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter7 += 1

        If counter7 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnPotato.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupPotato_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupPotato.ValueChanged
        btnPotato.Enabled = True
    End Sub

    Private Sub btnCucumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCucumber.Click
        Dim num As Integer = Val(nupCucumber.Text)
        Dim price As Double = 2.25 * num
        Dim ListItem As String = (num & " lb of Cucumbers - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter8 += 1

        If counter8 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnCucumber.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupCucumber_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupCucumber.ValueChanged
        btnCucumber.Enabled = True
    End Sub
    Private Sub btnTomato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTomato.Click
        Dim num As Integer = Val(nupTomato.Text)
        Dim price As Double = 2.79 * num
        Dim ListItem As String = (num & " lb of Tomato - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter9 += 1

        If counter9 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnTomato.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupTomato_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupTomato.ValueChanged
        btnTomato.Enabled = True
    End Sub

    Private Sub btnBroccoli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBroccoli.Click
        Dim num As Integer = Val(nupBroccoli.Text)
        Dim price As Double = 2.82 * num
        Dim ListItem As String = (num & " bunches of Broccoli - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter10 += 1

        If counter10 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnBroccoli.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupBroccoli_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupBroccoli.ValueChanged
        btnBroccoli.Enabled = True
    End Sub
    Private Sub btnOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrange.Click
        Dim num As Integer = Val(nupOrange.Text)
        Dim price As Double = 1.15 * num
        Dim ListItem As String = (num & " lb of Oranges - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter11 += 1

        If counter11 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnOrange.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupOrange_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupOrange.ValueChanged
        btnOrange.Enabled = True
    End Sub

    Private Sub btnApple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApple.Click
        Dim num As Integer = Val(nupApple.Text)
        Dim price As Double = 1.3 * num
        Dim ListItem As String = (num & " lb of Apple - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter12 += 1

        If counter12 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnApple.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupApple_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupApple.ValueChanged
        btnApple.Enabled = True
    End Sub
    Private Sub btnLemon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLemon.Click
        Dim num As Integer = Val(nupLemon.Text)
        Dim price As Double = 1.52 * num
        Dim ListItem As String = (num & " lb of Lemons - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter13 += 1

        If counter13 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnLemon.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupLemon_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupLemon.ValueChanged
        btnLemon.Enabled = True
    End Sub

    Private Sub btnBanana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBanana.Click
        Dim num As Integer = Val(nupBanana.Text)
        Dim price As Double = 0.79 * num
        Dim ListItem As String = (num & " lb of Bananas - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter14 += 1

        If counter14 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnBanana.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupBanana_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupBanana.ValueChanged
        btnBanana.Enabled = True
    End Sub
    Private Sub btnPineapple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPineapple.Click
        Dim num As Integer = Val(nupPineapple.Text)
        Dim price As Double = 3.65 * num
        Dim ListItem As String = (num & " Pineapple - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter15 += 1

        If counter15 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnPineapple.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupPineapple_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupPineapple.ValueChanged
        btnPineapple.Enabled = True
    End Sub

    Private Sub btnStrawberry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStrawberry.Click
        Dim num As Integer = Val(nupStrawberry.Text)
        Dim price As Double = 4.24 * num
        Dim ListItem As String = (num & " lb of Strawberries - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter16 += 1

        If counter16 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnStrawberry.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupStrawberry_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupStrawberry.ValueChanged
        btnStrawberry.Enabled = True
    End Sub

    Private Sub btnWatermelon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWatermelon.Click
        Dim num As Integer = Val(nupWatermelon.Text)
        Dim price As Double = 0.66 * num
        Dim ListItem As String = (num & " lb of Watermelon - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter17 += 1

        If counter17 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnWatermelon.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupWatermelon_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupWatermelon.ValueChanged
        btnWatermelon.Enabled = True
    End Sub

    Private Sub btnGrapes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrapes.Click
        Dim num As Integer = Val(nupGrapes.Text)
        Dim price As Double = 1.83 * num
        Dim ListItem As String = (num & " lb of Grapes - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter18 += 1

        If counter18 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnGrapes.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupGrapes_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupGrapes.ValueChanged
        btnGrapes.Enabled = True
    End Sub
    Private Sub btnKiwi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKiwi.Click
        Dim num As Integer = Val(nupKiwi.Text)
        Dim price As Double = 0.34 * num
        Dim ListItem As String = (num & " lb of Kiwi - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter19 += 1

        If counter19 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnKiwi.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub
    Private Sub nupKiwi_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupKiwi.ValueChanged
        btnKiwi.Enabled = True
    End Sub

    Private Sub btnMango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMango.Click
        Dim num As Integer = Val(nupMango.Text)
        Dim price As Double = 1.23 * num
        Dim ListItem As String = (num & " lb of Mangoes - " & FormatCurrency(price))
        Static Listitem1 As String = ListItem
        Dim CurrPos1 As Integer = lbxPrices.Items.IndexOf(Listitem1) 'The index is the location of the item in the listbox.'
        Static Subtract As Double = price
        'Every time the button is clicked, the counter goes up by one.'
        counter20 += 1

        If counter20 = 1 Then
            lbxPrices.Items.Add(ListItem) 'adds list item to the listbox'

            total += price
        Else
            'This code replaces the old list item with the old variables with the new item with the new variables at the index'
            lbxPrices.Items.RemoveAt(CurrPos1)
            lbxPrices.Items.Insert(CurrPos1, ListItem)
            'This code resets the static to the new variable'
            Listitem1 = ListItem
            total -= Subtract
            total += price
            Subtract = price

        End If
        btnMango.Enabled = False

        lblTotal.Text = "Total: " & FormatCurrency(total) ' changes the total amount every time the button is clicked.'
    End Sub

    Private Sub nupMango_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupMango.ValueChanged
        btnMango.Enabled = True
    End Sub
    Sub RESET()
        'This sub resets the counters and enables buttons'
        counter1 = 0
        counter2 = 0
        counter3 = 0
        counter4 = 0
        counter5 = 0
        counter6 = 0
        counter7 = 0
        counter8 = 0
        counter9 = 0
        counter10 = 0
        counter11 = 0
        counter12 = 0
        counter13 = 0
        counter14 = 0
        counter15 = 0
        counter16 = 0
        counter17 = 0
        counter18 = 0
        counter19 = 0
        counter20 = 0

        btnPeppers.Enabled = True
        btnLettuce.Enabled = True
        btnAsparagus.Enabled = True
        btnPineapple.Enabled = True
        btnPotato.Enabled = True
        btnApple.Enabled = True
        btnBanana.Enabled = True
        btnBroccoli.Enabled = True
        btnCarrot.Enabled = True
        btnCorn.Enabled = True
        btnCucumber.Enabled = True
        btnGrapes.Enabled = True
        btnMango.Enabled = True
        btnKiwi.Enabled = True
        btnWatermelon.Enabled = True
        btnSprouts.Enabled = True
        btnLemon.Enabled = True
        btnTomato.Enabled = True
        btnStrawberry.Enabled = True
        btnOrange.Enabled = True
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'this code resets the counters, total, list, and buttons'
        lbxPrices.Items.Clear()
        total = 0
        lblTotal.Text = "Total: " & FormatCurrency(total)
        Call RESET()
    End Sub


    Private Sub btnCheckout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckout.Click
        'this code resets the counters, list, total, and buttons, and also takes the total amount out of your wallet amount'

        If total > Wallet Then
            MessageBox.Show("I am sorry, you do not have enough funds to make that purchase.", "Transaction Cancelled")
        Else
            lbxPrices.Items.Clear()
            Wallet -= total
            lblWallet.Text = "Amount you are able to spend:   " & FormatCurrency(Wallet)
            total = 0
            lblTotal.Text = "Total: " & FormatCurrency(total)
            Call RESET()
        End If
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstructionsToolStripMenuItem.Click
        'This code brings up the instructions'
        Dim formtwo As New Form2
        formtwo.Show()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'This code prompts the user for confirmation before it closes the application https://msdn.microsoft.com/en-us/library/139z2azd(v=vs.90).aspx'
        Select Case MsgBox("Are you sure you want to finish shopping?", MsgBoxStyle.YesNo, "User Confirmation")
            Case MsgBoxResult.Yes
                MessageBox.Show("Alright, thank you for shopping with us!")
                Application.Exit()
            Case MsgBoxResult.No
                MessageBox.Show("Well then, keep on shopping!")
        End Select
    End Sub


End Class