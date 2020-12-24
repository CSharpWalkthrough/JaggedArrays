using System.IO;
using System.Windows.Forms;

namespace JaggedArrays
{
    public partial class FrmMain : Form
    {
        private string[][] memberClubs;
        public FrmMain()
        {
            InitializeComponent();

            // Read data file and Initialize jagged array
            InitializeMembers();

            // TODO: Display members in lstMembers control

        }

        private void lstMembers_Click(object sender, System.EventArgs e)
        {
            // TODO: Retrieve index of selected item


            // TODO: Clear lstClubs items


            // TODO: Retrieve row from memberClubs


            // TODO: Display clubs in lstClubs control

        }

        #region DO NOT EDIT
        private void InitializeMembers()
        {
            string[] lines = File.ReadAllLines("../../data.txt");
            memberClubs = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
                memberClubs[i] = lines[i].Split(',');
        }
        #endregion
    }
}
