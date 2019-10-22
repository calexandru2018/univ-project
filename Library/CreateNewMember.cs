using Library.Models;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class CreateNewMember : Form
    {
        private MemberService memberService;

        public CreateNewMember(MemberService ms)
        {
            memberService = ms;
            InitializeComponent();
        }

        private void CreateNewMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = new Member()
                {
                    SocialNumber = addMemberSocialNum.Text,
                    Name = addMemberName.Text,
                    MemberSince = DateTime.Now
                };
                memberService.Add(newMember);
            }
            catch
            {
                MessageBox.Show("Unable to create new member.");
            }


            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
