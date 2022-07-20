Public Class frmOperadoresLogicos

    Private Sub frmOperadoresLogicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbArit.SelectedIndex = 0
        cmbLog.SelectedIndex = 1
        cmbLog1.SelectedIndex = 0
        cmbLog2.SelectedIndex = 0
        cmbRel.SelectedIndex = 0

    End Sub



    Private Sub txtArit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArit1.KeyPress

        If txtArit1.Text = String.Empty Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-"

        ElseIf Not txtArit1.Text.Contains(".") Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."

        ElseIf Not txtArit1.Text.Contains("-") Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-"

        ElseIf txtArit1.Text.Contains(".") And txtArit1.Text.Contains("-") Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If

    End Sub

    Private Sub txtArit2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArit2.KeyPress

        If txtArit2.Text = String.Empty Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-"

        ElseIf Not txtArit2.Text.Contains(".") Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."

        ElseIf Not txtArit2.Text.Contains("-") Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-"

        ElseIf txtArit2.Text.Contains(".") And txtArit2.Text.Contains("-") Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If

    End Sub







    'Aritmeticos
    Public Sub cmbArit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArit.SelectedIndexChanged

        If ((txtArit1.Text IsNot String.Empty) And (txtArit2.Text IsNot String.Empty)) Then

            If txtArit1.Text Like "*.*-*" Or txtArit1.Text Like "." Or txtArit1.Text Like "-" Or txtArit1.Text Like "-." Or txtArit2.Text Like "*.-*" Or txtArit2.Text Like "." Or txtArit2.Text Like "-" Or txtArit2.Text Like "-." Then

                MsgBox("Valor invalido")
                Exit Sub

            End If

            If cmbArit.SelectedItem = "+" Then

                MsgBox(Convert.ToDouble(txtArit1.Text) + Convert.ToDouble(txtArit2.Text))

            ElseIf cmbArit.SelectedItem = "-" Then

                MsgBox(Convert.ToDouble(txtArit1.Text) - Convert.ToDouble(txtArit2.Text))

            ElseIf cmbArit.SelectedItem = "*" Then

                MsgBox(Convert.ToDouble(txtArit1.Text) * Convert.ToDouble(txtArit2.Text))

            ElseIf cmbArit.SelectedItem = "/" Then

                MsgBox(Convert.ToDouble(txtArit1.Text) / Convert.ToDouble(txtArit2.Text))

            ElseIf cmbArit.SelectedItem = "\" Then

                MsgBox(Convert.ToDouble(txtArit1.Text) \ Convert.ToDouble(txtArit2.Text))

            ElseIf cmbArit.SelectedItem = "Mod" Then

                MsgBox(Convert.ToDouble(txtArit1.Text) Mod Convert.ToDouble(txtArit2.Text))

            ElseIf cmbArit.SelectedItem = "^" Then

                MsgBox(Convert.ToDouble(txtArit1.Text) ^ Convert.ToDouble(txtArit2.Text))

            End If

        End If

    End Sub





    'Logicos
    Private Sub cmbLog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLog.SelectedIndexChanged

        cmbLog2.Enabled = True

        If cmbLog1.Text IsNot String.Empty Then

            If cmbLog.SelectedItem = "Not" Then

                cmbLog2.Enabled = False
                MsgBox(Not (Convert.ToBoolean(cmbLog1.SelectedIndex)))

            End If

        End If

        If ((cmbLog1.Text IsNot String.Empty) And (cmbLog2.Text IsNot String.Empty)) Then

            If cmbLog.SelectedItem = "And" Then

                MsgBox(Convert.ToBoolean(cmbLog1.SelectedIndex) And Convert.ToBoolean(cmbLog2.SelectedIndex))

            ElseIf cmbLog.SelectedItem = "Or" Then

                MsgBox(Convert.ToBoolean(cmbLog1.SelectedIndex) Or Convert.ToBoolean(cmbLog2.SelectedIndex))

            ElseIf cmbLog.SelectedItem = "Xor" Then

                MsgBox(Convert.ToBoolean(cmbLog1.SelectedIndex) Xor Convert.ToBoolean(cmbLog2.SelectedIndex))

            End If

        End If

    End Sub








    'Relacionales
    Private Sub cmbRel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRel.SelectedIndexChanged

        If ((txtRel1.Text IsNot String.Empty) And (txtRel2.Text IsNot String.Empty)) Then


            If cmbRel.SelectedItem = ">" Then

                MsgBox(txtRel1.Text > txtRel2.Text)

            ElseIf cmbRel.SelectedItem = "<" Then

                MsgBox(txtRel1.Text < txtRel2.Text)

            ElseIf cmbRel.SelectedItem = "<=" Then

                MsgBox(txtRel1.Text <= txtRel2.Text)

            ElseIf cmbRel.SelectedItem = ">=" Then

                MsgBox(txtRel1.Text >= txtRel2.Text)

            ElseIf cmbRel.SelectedItem = "=" Then

                MsgBox(txtRel1.Text = txtRel2.Text)

            ElseIf cmbRel.SelectedItem = "<>" Then

                MsgBox(txtRel1.Text <> txtRel2.Text)

            End If


        End If

    End Sub


End Class
