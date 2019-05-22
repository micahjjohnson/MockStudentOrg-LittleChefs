using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleChefs
{
    public partial class Form11 : Form
    {
        private List<string> options = new List<string>();
        private List<string> backup = new List<string>();

        public Form11()
        {
            InitializeComponent();
            options.Add("Absent");
            options.Add("Present");
            options.Add("Excused");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Point mousePosition = listView1.PointToClient(Control.MousePosition);
            //ListViewHitTestInfo hit = listView1.HitTest(mousePosition);
            foreach (ListViewItem item in listView1.Items)
            {
                if (!item.Checked)
                {
                    item.SubItems[2].Text = "Absent";
                }
                else
                {
                    item.SubItems[2].Text = "Present";
                }
            }

                    /*
                    if (options.Count != 0)
                    {
                        item.SubItems[2].Text = cycleOptions();
                        removeLast();
                        break;
                    }
                    else
                    {
                        foreach (string s in backup)
                        {
                            options.Add(s);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("checked");
                }
                }
                */
            }

        private string cycleOptions()
        {
            return options[0];
        }

        private void removeLast()
        {
            backup.Add(options[0]);
            options.RemoveAt(0);
        }
    }
}
