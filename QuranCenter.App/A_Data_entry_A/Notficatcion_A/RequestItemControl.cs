using System;
using System.Drawing;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class RequestItemControl : UserControl
    {
        private Request _requestData;

        public RequestItemControl()
        {
            InitializeComponent();

            // This is the corrected code to handle clicks properly and avoid stack overflow.
            // We create a single handler that will be used by all CHILD controls.
            EventHandler childClickHandler = (sender, e) =>
            {
                // When a child control (like a Label or PictureBox) is clicked,
                // we programmatically raise the parent UserControl's Click event.
                this.OnClick(e);
            };

            // Now, we loop through all child controls inside this UserControl
            // and make them trigger the parent's click event.
            foreach (Control control in this.Controls)
            {
                control.Click += childClickHandler;
            }
            // IMPORTANT: We do not subscribe the parent control (this) to this handler,
            // as that would cause the infinite loop.
        }

        public Request RequestData
        {
            get { return _requestData; }
            set
            {
                _requestData = value;
                // Update the UI when data is set
                if (_requestData != null)
                {
                    DisplayRequestData();
                }
            }
        }

        private void DisplayRequestData()
        {
            lblSubject.Text = _requestData.SubjectName;
            lblDate.Text = _requestData.RequestDate.ToString("yyyy/MM/dd hh:mm tt");

            // Customize display based on request type
            switch (_requestData.Type)
            {
                case RequestType.StudentTransfer:
                    lblTitle.Text = "طلب نقل طالب";
                    // You can set a specific icon for transfers from Properties.Resources
                    // picIcon.Image = Properties.Resources.transfer_icon; 
                    break;
                case RequestType.DataModification:
                    lblTitle.Text = "طلب تعديل بيانات";
                    // You can set a specific icon for modifications from Properties.Resources
                    // picIcon.Image = Properties.Resources.edit_icon; 
                    break;
            }

            // Customize status indicator color
            switch (_requestData.Status)
            {
                case RequestStatus.Pending:
                    pnlStatus.BackColor = Color.DodgerBlue;
                    break;
                case RequestStatus.Approved:
                    pnlStatus.BackColor = Color.MediumSeaGreen;
                    break;
                case RequestStatus.Rejected:
                    pnlStatus.BackColor = Color.Tomato;
                    break;
            }
        }
    }
}

