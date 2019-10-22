using Library.Models;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        // Add new member, can´t change button name : (
        private void button1_Click(object sender, EventArgs e)
        {
            string SocialNumber = addMemberSocialNum.Text;
            string Name = addMemberName.Text;
            Regex rx = new Regex(@"^([0-9]{6,8}-[0-9]{4}|[0-9]{6,8})$");
            if (rx.Match(SocialNumber).Success)
            {
                Member newMember = new Member()
                {
                    SocialNumber = SocialNumber,
                    MemberSince = DateTime.Now
                };
                memberService.Add(newMember);
            }
            else
            {
                MessageBox.Show("Incorrect social number format. Format (yy)yymmdd-xxxx or (yy)yymmdd ");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewMember_Load(object sender, EventArgs e)
        {

        }
    }
}
