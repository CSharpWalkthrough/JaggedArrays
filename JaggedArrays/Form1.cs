using System.Windows.Forms;

namespace JaggedArrays
{
    public partial class frmClubMembers : Form
    {
        public frmClubMembers()
        {
            InitializeComponent();

            // Initialize jagged array
            string[][] memberClubs = new string[3][];
            memberClubs[0] = new string[] { "Jack", "Music", "Tennis", "Chess" };
            memberClubs[1] = new string[] { "Max", "Tennis" };
            memberClubs[2] = new string[] { "Alice","Tennis", "Chess", "Basketball", "Soccer" };

            // Display members in lstMembers control
            foreach (string[] memberClub in memberClubs)
                lstMembers.Items.Add(memberClub[0]);

            string[] clubs = memberClubs[0];
            for (int i = 1; i < clubs.Length; i++)
                lstClubs.Items.Add(clubs[i]);
        }
    }
}
