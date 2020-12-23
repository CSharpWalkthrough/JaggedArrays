using System.Windows.Forms;

namespace JaggedArrays
{
    public partial class frmClubMembers : Form
    {
        string[][] memberClubs = new string[10][];
        public frmClubMembers()
        {
            InitializeComponent();

            // Initialize jagged array
            memberClubs[0] = new string[] { "Jack", "Music", "Tennis", "Chess" };
            memberClubs[1] = new string[] { "Max", "Tennis" };
            memberClubs[2] = new string[] { "Alice", "Music", "Chess", "Basketball", "Soccer" };
            memberClubs[3] = new string[] { "Rick","Tennis", "Basketball", "Soccer" };
            memberClubs[4] = new string[] { "Kaylie","Tennis", "Chess", "Basketball", "Soccer", "Ski" };
            memberClubs[5] = new string[] { "Steve", "Music", "Soccer" };
            memberClubs[6] = new string[] { "Shanw","Tennis", "Chess", "Soccer" };
            memberClubs[7] = new string[] { "Olivia", "Music", "Chess", "Basketball", "Ski" };
            memberClubs[8] = new string[] { "Lauren", "Chess" };
            memberClubs[9] = new string[] { "Terry","Tennis", "Chess" };

            // Display members in lstMembers control
            foreach (string[] memberClub in memberClubs)
                lstMembers.Items.Add(memberClub[0]);

            
        }

        private void lstMembers_Click(object sender, System.EventArgs e)
        {
            // Retrieve index of selected item
            int index = lstMembers.SelectedIndex;

            // Clear lstClubs items
            lstClubs.Items.Clear();

            // Retrieve row from memberClubs
            string[] clubs = memberClubs[index];

            // Display clubs in lstClubs control
            for (int i = 1; i < clubs.Length; i++)
                lstClubs.Items.Add(clubs[i]);
        }
    }
}
