using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Utilities
{
    public static class SD
    {
        public const string Role_Customer = "Customer";
        public const string Role_Company = "Company";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Empolyee";

        public const string StatusPending = "Pending";
		public const string StatusApproved = "Approved";
		public const string StatusInProcess = "Processing";
		public const string StatusShipped = "Shipped";
		public const string StatusCancelled = "Cancelled";
		public const string StatusRefunded = "Refunded";

		public const string PymentStatusPending = "Pending";
		public const string PymentStatusApproved = "Approved";
		public const string PymentStatusDelayedPayment = "ApprovedForDelayedPayment";
		public const string PymentStatusRejected = "Rejected";

		public const string SessionCart = "SessionShoppingCart";
	}
}
