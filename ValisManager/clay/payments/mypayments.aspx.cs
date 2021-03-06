using System;
using System.Globalization;

namespace ValisManager.clay.payments
{
    public partial class mypayments : ManagerPage
    {
        #region JqGrid support
        /// <summary>
        /// jqGrid's current page
        /// </summary>
        protected string PageNumber
        {
            get
            {
                string pageno = this.Request.Params["pageno"];
                if (string.IsNullOrEmpty(pageno))
                {
                    return "1";
                }
                try
                {
                    return Int32.Parse(pageno, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
                }
                catch
                {
                    return "1";
                }
            }
        }
        /// <summary>
        /// jqGrid's current sortname
        /// </summary>
        protected string SortName
        {
            get
            {
                string sortname = this.Request.Params["sortname"];
                if (string.IsNullOrEmpty(sortname))
                {
                    return "PaymentDate";
                }
                return sortname;
            }
        }
        /// <summary>
        /// jqGrid's current sortorder
        /// </summary>
        protected string SortOrder
        {
            get
            {
                string sortorder = this.Request.Params["sortorder"];
                if (string.IsNullOrEmpty(sortorder))
                {
                    return "asc";
                }
                return sortorder;
            }
        }
        /// <summary>
        /// jqGrid's current rownum
        /// </summary>
        protected string RowNum
        {
            get
            {
                string rowNum = this.Request.Params["rowNum"] as string;
                if (string.IsNullOrEmpty(rowNum))
                {
                    return "12";
                }
                try
                {
                    return Int32.Parse(rowNum, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
                }
                catch
                {
                    return "12";
                }
            }
        }
        #endregion



        protected override void OnPreLoad(EventArgs e)
        {
            base.OnPreLoad(e);

            this.balanceStatistics1.SurveyClientId = this.ClientId;
        }


    }
}