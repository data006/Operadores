using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresCS
{
	public partial class frmOperadoresCS : Form
	{
		public frmOperadoresCS()
		{
			InitializeComponent();
		}

		private void frmOperadoresCS_Load(object sender, EventArgs e)
		{

			cmbArit.SelectedIndex = 0;
			cmbLog.SelectedIndex = 1;
			cmbLog1.SelectedIndex = 0;
			cmbLog2.SelectedIndex = 0;
			cmbRel.SelectedIndex = 0;

		}

		private void txtArit1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (string.IsNullOrEmpty(txtArit1.Text))
			{

				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar.Equals(".")) && !(e.KeyChar.Equals("-"));
			}
			else if (!txtArit1.Text.Contains("."))
			{

				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar.Equals("."));

			}
			else if (!txtArit1.Text.Contains("-"))
			{

				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar.Equals("-"));

			}
			else if (txtArit1.Text.Contains(".") & txtArit1.Text.Contains("-"))
			{

				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

			}

		}

		private void txtArit2_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (string.IsNullOrEmpty(txtArit2.Text))
			{

				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar.Equals(".")) && !(e.KeyChar.Equals("-"));
			}
			else if (!txtArit2.Text.Contains("."))
			{

				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar.Equals("."));

			}
			else if (!txtArit2.Text.Contains("-"))
			{

				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar.Equals("-"));

			}
			else if (txtArit2.Text.Contains(".") & txtArit1.Text.Contains("-"))
			{

				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

			}

		}









		//Aritmeticos
		private void cmbArit_SelectedIndexChanged(object sender, EventArgs e)
		{

			if ((!string.IsNullOrEmpty(txtArit1.Text)) && (!string.IsNullOrEmpty(txtArit2.Text)))
			{

				if (LikeOperator.LikeString(txtArit1.Text, "*.*-*", CompareMethod.Binary) | LikeOperator.LikeString(txtArit1.Text, ".", CompareMethod.Binary) | LikeOperator.LikeString(txtArit1.Text, "-", CompareMethod.Binary) | LikeOperator.LikeString(txtArit1.Text, "-.", CompareMethod.Binary) | LikeOperator.LikeString(txtArit2.Text, "*.-*", CompareMethod.Binary) | LikeOperator.LikeString(txtArit2.Text, ".", CompareMethod.Binary) | LikeOperator.LikeString(txtArit2.Text, "-", CompareMethod.Binary) | LikeOperator.LikeString(txtArit2.Text, "-.", CompareMethod.Binary))
				{
					MessageBox.Show("Valor invalido");
					return;
				}

				




				if (cmbArit.SelectedItem.Equals("+"))
				{

					MessageBox.Show(Convert.ToString(Convert.ToDouble(txtArit1.Text) + Convert.ToDouble(txtArit2.Text)));

				}
				else if (cmbArit.SelectedItem.Equals("-"))
				{

					MessageBox.Show(Convert.ToString(Convert.ToDouble(txtArit1.Text) - Convert.ToDouble(txtArit2.Text)));

				}
				else if (cmbArit.SelectedItem.Equals("*"))
				{

					MessageBox.Show(Convert.ToString(Convert.ToDouble(txtArit1.Text) * Convert.ToDouble(txtArit2.Text)));

				}
				else if (cmbArit.SelectedItem.Equals("/"))
				{

					MessageBox.Show(Convert.ToString(Convert.ToDouble(txtArit1.Text) / Convert.ToDouble(txtArit2.Text)));

				}
				else if (cmbArit.SelectedItem.Equals("\\"))
				{

					MessageBox.Show(Convert.ToString(Convert.ToInt32(Convert.ToDouble(txtArit1.Text)) / Convert.ToInt32(Convert.ToDouble(txtArit2.Text))));

				}
				else if (cmbArit.SelectedItem.Equals("Mod"))
				{

					MessageBox.Show(Convert.ToString(Convert.ToDouble(txtArit1.Text) % Convert.ToDouble(txtArit2.Text)));

				}
				else if (cmbArit.SelectedItem.Equals("^"))
				{

					MessageBox.Show(Convert.ToString(Math.Pow(Convert.ToDouble(txtArit1.Text), Convert.ToDouble(txtArit2.Text))));

				}
			}

		}







		//Logicos

		private void cmbLog_SelectedIndexChanged(object sender, EventArgs e)
		{

			

			if (!string.IsNullOrEmpty(cmbLog1.Text))
			{

				if (cmbLog.SelectedItem.Equals( "Not"))
				{

					cmbLog2.Enabled = false;
					MessageBox.Show(Convert.ToString(!(Convert.ToBoolean(cmbLog1.SelectedIndex))));

				}
				else
				{
					cmbLog2.Enabled = true;
				}

			}


			if ((!string.IsNullOrEmpty(cmbLog1.Text)) && (!string.IsNullOrEmpty(cmbLog2.Text)))
			{
				
				if (cmbLog.SelectedItem.Equals( "And"))
				{

					MessageBox.Show(Convert.ToString(Convert.ToBoolean(cmbLog1.SelectedIndex) & Convert.ToBoolean(cmbLog2.SelectedIndex)));

				}
				else if (cmbLog.SelectedItem.Equals("Or"))
				{

					MessageBox.Show(Convert.ToString(Convert.ToBoolean(cmbLog1.SelectedIndex) | Convert.ToBoolean(cmbLog2.SelectedIndex)));

				}
				else if (cmbLog.SelectedItem.Equals("Xor"))
				{

					MessageBox.Show(Convert.ToString(Convert.ToBoolean(cmbLog1.SelectedIndex) ^ Convert.ToBoolean(cmbLog2.SelectedIndex)));

				}


			}



		}





		//Relacionales
		private void cmbRel_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (txtRel1.Text != string.Empty & txtRel2.Text != string.Empty)
			{
				if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbRel.SelectedItem, ">", false)))
				{
					MessageBox.Show(Convert.ToString(txtRel1.Text.Length > txtRel2.Text.Length));
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbRel.SelectedItem, "<", false)))
				{
					MessageBox.Show(Convert.ToString(txtRel1.Text.Length < txtRel2.Text.Length));
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbRel.SelectedItem, "<=", false)))
				{
					MessageBox.Show(Convert.ToString(txtRel1.Text.Length <= txtRel2.Text.Length));
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbRel.SelectedItem, ">=", false)))
				{
					MessageBox.Show(Convert.ToString(txtRel1.Text.Length >= txtRel2.Text.Length));
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbRel.SelectedItem, "==", false)))
				{
					MessageBox.Show(Convert.ToString((txtRel1.Text) == (txtRel2.Text)));
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbRel.SelectedItem, "!=", false)))
				{
					MessageBox.Show(Convert.ToString((txtRel1.Text) != (txtRel2.Text)));
				}
			}


		}

















	}
	}
