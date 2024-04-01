using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta_MdVA
{
    public partial class ConfirmAge : Form
    {
        public ConfirmAge()
        {
            InitializeComponent();

            pnl_Body.BackColor = Color.FromArgb(50,0,0,0);
            lbl_Title.BackColor = Color.Transparent;
            lbl_Day.BackColor = Color.Transparent;
            lbl_Month.BackColor = Color.Transparent;
            lbl_Year.BackColor = Color.Transparent;
            
            cmbBx_Day.Items.AddRange(fillInfo(0));
            cmbBx_Month.Items.AddRange(fillInfo(1));
            cmbBx_Year.Items.AddRange(fillInfo(2));
        }
        public object[] fillInfo(int box)
        {
            object[] toRetrurnList;

            switch (box)
            {
                case 0:
                    toRetrurnList = new System.Object[31];
                    for (int i = 1; i < toRetrurnList.Length + 1; i++)
                    {
                        toRetrurnList[i - 1] = "" + i;
                    }
                    break;
                case 1:
                    toRetrurnList = new object[] { "Janeiro", "Fevereiro", "Março", "Abril",
                    "Maio", "Junho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
                    break;
                case 2:
                    toRetrurnList = new System.Object[128];

                    for (int i = 0; i < toRetrurnList.Length; i++)
                    {
                        toRetrurnList[i] = "" + (DateTime.Now.Year - i);
                    }
                    break;
                default:
                    toRetrurnList = new object[] { 0 };
                    break;
            }

            return toRetrurnList;
        }

        private bool verifyAge(DateTime userBirth)
        {
            DateTime currDate = DateTime.Now.Date;

            if (currDate > userBirth.AddYears(18))
            {
                MessageBox.Show("É maior que 18", "Aprovado para a Loja");
                return true;
            }
            else if (currDate < userBirth.AddYears(18))
            {
                MessageBox.Show("Não é maior que 18", "HAHA LOSER LOSER LIXO");
                return false;
            }
            else
            {
                MessageBox.Show("É maior que 18 Anos, Feliz aniversário", "Feliz aniversario");
                return true;
            }
        }

        private void checkUserData()
        {

            DateTime userBirth;
            String birthdate = "";

            if (!$"{cmbBx_Day.SelectedItem}".Equals(""))
            {
                birthdate += "" + cmbBx_Day.SelectedItem + "/";
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data valida", "Dados Invalidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            switch ("" + cmbBx_Month.SelectedItem)
            {
                case "Janeiro":
                    birthdate += "01";
                    break;
                case "Fevereiro":
                    birthdate += "02";
                    break;
                case "Março":
                    birthdate += "03";
                    break;
                case "Abril":
                    birthdate += "04";
                    break;
                case "Maio":
                    birthdate += "05";
                    break;
                case "Junho":
                    birthdate += "06";
                    break;
                case "Julho":
                    birthdate += "07";
                    break;
                case "Agosto":
                    birthdate += "08";
                    break;
                case "Setembro":
                    birthdate += "09";
                    break;
                case "Outubro":
                    birthdate += "10";
                    break;
                case "Novembro":
                    birthdate += "11";
                    break;
                case "Dezembro":
                    birthdate += "12";
                    break;
                default:
                    MessageBox.Show("Por favor, insira uma data valida", "Dados Invalidos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            if (!$"{cmbBx_Year.SelectedItem}".Equals(""))
            {
                birthdate += "/" + cmbBx_Year.SelectedItem + " 00:00:00";
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data valida", "Dados Invalidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userBirth = DateTime.Parse(birthdate);

            if (verifyAge(userBirth))
            {
                Conductor.changeForm(1);
            }

        }

        private void bttn_Check_Click(object sender, EventArgs e)
        {
            checkUserData();
        }
    }
}
