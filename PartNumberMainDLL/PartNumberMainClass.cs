/* Title:           Part Number Main Class
 * Date:            7-29-20
 * Author:          Terry Holmes
 * 
 * Description:     This is used to replace the part number class */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace PartNumberMainDLL
{
    public class PartNumberMainClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        PartNumberReferenceDataSet aPartNumberReferenceDataSet;
        PartNumberReferenceDataSetTableAdapters.partnumberreferenceTableAdapter aPartNumberReferenceTableAdapter;

        public PartNumberReferenceDataSet GetPartNumberReferenceInfo()
        {
            try
            {
                aPartNumberReferenceDataSet = new PartNumberReferenceDataSet();
                aPartNumberReferenceTableAdapter = new PartNumberReferenceDataSetTableAdapters.partnumberreferenceTableAdapter();
                aPartNumberReferenceTableAdapter.Fill(aPartNumberReferenceDataSet.partnumberreference);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Get Part Number Reference Info " + Ex.Message);
            }

            return aPartNumberReferenceDataSet;
        }
        public void UpdatePartNumberReferenceDB(PartNumberReferenceDataSet aPartNumberReferenceDataSet)
        {
            try
            {
                aPartNumberReferenceTableAdapter = new PartNumberReferenceDataSetTableAdapters.partnumberreferenceTableAdapter();
                aPartNumberReferenceTableAdapter.Update(aPartNumberReferenceDataSet.partnumberreference);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Update Part Number Reference DB " + Ex.Message);
            }
        }
    }
}
