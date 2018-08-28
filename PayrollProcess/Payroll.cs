using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace PayrollProcess
{
    public class Payroll
    {
        private bool isWeeklyOff(DateTime pdate, ref object prsEmp)
        {
            int iWeek;
            int iWeekDay;
            iWeek = pdate.Day / 7 + 1;
            //iWeekDay = pdate. - 1;

            //isWeeklyOff = false;
            //if (prsEmp.EOF)
            //    return;
            //else if (iWeekDay == System.Convert.ToInt32(prsEmp.Weekly_Off1))
            //{
            //    if (InStr(prsEmp.Weekly_Off1_Days, System.Convert.ToString(iWeek)) > 0)
            //        isWeeklyOff = true;
            //}
            //else if (iWeekDay == System.Convert.ToInt32(prsEmp.Weekly_Off2))
            //{
            //    if (InStr(prsEmp.Weekly_Off2_Days, System.Convert.ToString(iWeek)) > 0)
            //        isWeeklyOff = true;
            //}
            //else
            //    return;

            return false;
        }

        //private void autoEncashment(string psEID, ref ADODB.Recordset prsLeaveMaster, ref ADODB.Recordset prsLeaveApps, ref ADODB.Recordset prsLBal_S, ref ADODB.Recordset prsEncash, string psGradeID, string psLocID, DateTime pdtMonth)
        //{
        //    string sLID;
        //    float sngLeave;
        //    float sngEncashed;
        //    float sngEncashable;
        //    ADODB.Recordset rsApp;
        //    int iAppNo;

        //    prsLeaveMaster.Filter = adFilterNone;
        //    gstrqry = "GradeID = '" + psGradeID + "' AND LocID = '" + psLocID + "' AND AutoEncash = 'M'"; CheckQry();
        //    prsLeaveMaster.Filter = gstrqry;

        //    if (prsLeaveMaster.RecordCount > 0)
        //        prsLeaveMaster.MoveFirst();
        //    else
        //        return;

        //    if (gdbType == "Access")
        //        gstrqry = "SELECT MAX(VAL(App_No)) FROM LeaveEncashment";
        //    else
        //        gstrqry = "SELECT MAX(CAST(App_No AS INT)) FROM LeaveEncashment";
        //    OpenRS(rsApp);
        //    iAppNo = System.Convert.ToInt32(sngNullZero(rsApp.Fields(0).Value)) + 1;

        //    while (!prsLeaveMaster.EOF)
        //    {
        //        sLID = prsLeaveMaster.leave_id;
        //        prsLeaveApps.Filter = adFilterNone; prsLeaveApps.Filter = "Emp_ID = '" + psEID + "' AND LeaveType = '" + sLID + "'"; if (prsLeaveApps.RecordCount > 0)
        //            prsLeaveApps.MoveFirst();
        //        sngLeave = 0;
        //        while (!prsLeaveApps.EOF)
        //        {
        //            sngLeave = sngLeave + Leaves(psEID, prsLeaveApps.Date_From, prsLeaveApps.Date_To, prsLeaveApps.half2nd == "S", prsLeaveApps.half1st == "F");
        //            prsLeaveApps.MoveNext();
        //        }

        //        sngEncashed = 0;
        //        prsEncash.Filter = adFilterNone; prsEncash.Filter = "Emp_ID = '" + psEID + "' AND Leave_Type = '" + sLID + "'"; if (prsEncash.RecordCount > 0)
        //            prsEncash.MoveFirst();
        //        while (!prsEncash.EOF)
        //        {
        //            sngEncashed = sngEncashed + prsEncash.Encashing_Days;
        //            prsEncash.MoveNext();
        //        }

        //        prsLBal_S.Filter = adFilterNone;
        //        gstrqry = "Emp_ID = '" + psEID + "' AND Leave_ID = '" + sLID + "' AND Month = #" + pdtMonth + "#"; CheckQry();
        //        prsLBal_S.Filter = gstrqry;
        //        if (prsLBal_S.RecordCount > 0)
        //        {
        //            prsLBal_S.MoveFirst();
        //            sngEncashable = prsLBal_S.O_Bal + prsLBal_S.Accrued - prsLBal_S.Utilized - prsLBal_S.Encashed - sngLeave - sngEncashed;
        //            if (sngEncashable > 0)
        //            {
        //                gstrqry = "INSERT INTO LeaveEncashment VALUES('" + Strings.Format(iAppNo, "00000") + "', " + "#" + DateTime + "#, " + "'" + psEID + "', " + "'" + sLID + "', " + sngEncashable + ", 'A', " + "'" + 999 + "', " + "'Auto Generated', " + "#" + pdtMonth + "#, 0, " + "#" + DateTime + "#)";
        //                CheckQry();
        //                dbHRSoft.Execute(gstrqry);
        //            }
        //        }
        //        prsLeaveMaster.MoveNext();
        //    }
        //}

    }
}
