/* Title:           Part Number Main Class
 * Date:            7-29-20
 * Author:          Terry Holmes
 * 
 * Description:     This is used to replace the part number class */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
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

        InsertPartNumberReferenceEntryTableAdapters.QueriesTableAdapter aInsertPartNumberReferenceTableAdapter;

        UpdatePartNumberReferernceActiveEntryTableAdapters.QueriesTableAdapter aUpdatePartNumberReferenceActiveTableAdapter;

        UpdatePartNumberReferencePartIDTableAdapters.QueriesTableAdapter aUpdatePartNumberReferencePartIDTableAdapter;

        FindPartNumberReferenceByPartNumberDataSet aFindPartNumberReferenceByPartNumberDataSet;
        FindPartNumberReferenceByPartNumberDataSetTableAdapters.FindPartNumberReferenceByPartNumberTableAdapter aFindPartNumberReferenceByPartNumberTableAdapter;

        FindPartNumberReferenceByJDEPartNumberDataSet aFindPartNumberReferenceByJDEPartNumberDataSet;
        FindPartNumberReferenceByJDEPartNumberDataSetTableAdapters.FindPartNumberReferenceByJDEPartNumberTableAdapter aFindPartNumberReferenceByJDEPartNumberTableAdapter;

        FindActivePartNumberReferenceByPartIDDataSet aFindActivePartNumberReferenceByPartIDDataSet;
        FindActivePartNumberReferenceByPartIDDataSetTableAdapters.FindActivePartNumberReferenceByPartIDTableAdapter aFindActivePartNumberReferenceByPartIDTableAdapter;

        PartNumberMainDataSet aPartNumberMainDataSet;
        PartNumberMainDataSetTableAdapters.partnumbermainTableAdapter aPartNumberMainTableAdapter;

        InsertPartNumberMainEntryTableAdapters.QueriesTableAdapter aInsertPartNumberMainTableAdapter;

        FindPartNumberMainByPartIDDataSet aFindPartNumberMainByPartIDDataSet;
        FindPartNumberMainByPartIDDataSetTableAdapters.FindPartNumberMainByPartIDTableAdapter aFindPartNumberMainByPartIDTableAdapter;

        FindPartNumberMainByPartNumberDataSet aFindPartNumberMainByPartNumberDataSet;
        FindPartNumberMainByPartNumberDataSetTableAdapters.FindPartNumberMainByPartNumberTableAdapter aFindPartNumberMainByPartNumberTableAdapter;

        FindPartNumberMainByJDEPartNumberDataSet aFindPartNumberMainByJDEPartNumberDataSet;
        FindPartNumberMainByJDEPartNumberDataSetTableAdapters.FindPartNumberMainByJDEPartNumberTableAdapter aFindPartNumberMainByJDEPartNumberTableAdapter;

        public FindPartNumberMainByJDEPartNumberDataSet FindPartNumberMainByJDEPartNumber(string strJDEPartNumber)
        {
            try
            {
                aFindPartNumberMainByJDEPartNumberDataSet = new FindPartNumberMainByJDEPartNumberDataSet();
                aFindPartNumberMainByJDEPartNumberTableAdapter = new FindPartNumberMainByJDEPartNumberDataSetTableAdapters.FindPartNumberMainByJDEPartNumberTableAdapter();
                aFindPartNumberMainByJDEPartNumberTableAdapter.Fill(aFindPartNumberMainByJDEPartNumberDataSet.FindPartNumberMainByJDEPartNumber, strJDEPartNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Find Part Number Main By JDE Part Number " + Ex.Message);
            }

            return aFindPartNumberMainByJDEPartNumberDataSet;
        }
        public FindPartNumberMainByPartNumberDataSet FindPartNumberMainByPartNumber(string strPartNumber)
        {
            try
            {
                aFindPartNumberMainByPartNumberDataSet = new FindPartNumberMainByPartNumberDataSet();
                aFindPartNumberMainByPartNumberTableAdapter = new FindPartNumberMainByPartNumberDataSetTableAdapters.FindPartNumberMainByPartNumberTableAdapter();
                aFindPartNumberMainByPartNumberTableAdapter.Fill(aFindPartNumberMainByPartNumberDataSet.FindPartNumberMainByPartNumber, strPartNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Find Part Number Main By Part Number " + Ex.Message);
            }

            return aFindPartNumberMainByPartNumberDataSet;
        }
        public FindPartNumberMainByPartIDDataSet FindPartNumberMainByPartID(int intPartID)
        {
            try
            {
                aFindPartNumberMainByPartIDDataSet = new FindPartNumberMainByPartIDDataSet();
                aFindPartNumberMainByPartIDTableAdapter = new FindPartNumberMainByPartIDDataSetTableAdapters.FindPartNumberMainByPartIDTableAdapter();
                aFindPartNumberMainByPartIDTableAdapter.Fill(aFindPartNumberMainByPartIDDataSet.FindPartNumberMainByPartID, intPartID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Find Part Number Main By Part ID " + Ex.Message);
            }

            return aFindPartNumberMainByPartIDDataSet;
        }
        public bool InsertPartNumberMain(string strPartDescription, decimal decPartPrice)
        {
            bool blnFatalError = false;

            try
            {
                aInsertPartNumberMainTableAdapter = new InsertPartNumberMainEntryTableAdapters.QueriesTableAdapter();
                aInsertPartNumberMainTableAdapter.InsertPartNumberMain(strPartDescription, true, decPartPrice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Insert Part Number Main " + Ex.Message);
            }

            return blnFatalError;
        }
        public PartNumberMainDataSet GetPartNumberMainInfo()
        {
            try
            {
                aPartNumberMainDataSet = new PartNumberMainDataSet();
                aPartNumberMainTableAdapter = new PartNumberMainDataSetTableAdapters.partnumbermainTableAdapter();
                aPartNumberMainTableAdapter.Fill(aPartNumberMainDataSet.partnumbermain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Get Part Number Main Info " + Ex.Message);
            }

            return aPartNumberMainDataSet;
        }
        public void UpdatePartNumberMainDB(PartNumberMainDataSet aPartNumberMainDataSet)
        {
            try
            {
                aPartNumberMainTableAdapter = new PartNumberMainDataSetTableAdapters.partnumbermainTableAdapter();
                aPartNumberMainTableAdapter.Update(aPartNumberMainDataSet.partnumbermain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Update Part Number Main DB " + Ex.Message);
            }
        }
        public FindActivePartNumberReferenceByPartIDDataSet FindActivePartNumberReferenceByPartID(int intPartID)
        {
            try
            {
                aFindActivePartNumberReferenceByPartIDDataSet = new FindActivePartNumberReferenceByPartIDDataSet();
                aFindActivePartNumberReferenceByPartIDTableAdapter = new FindActivePartNumberReferenceByPartIDDataSetTableAdapters.FindActivePartNumberReferenceByPartIDTableAdapter();
                aFindActivePartNumberReferenceByPartIDTableAdapter.Fill(aFindActivePartNumberReferenceByPartIDDataSet.FindActivePartNumberReferenceByPartID, intPartID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Find Active Part Number Reference By Part ID " + Ex.Message);
            }

            return aFindActivePartNumberReferenceByPartIDDataSet;
        }
        public FindPartNumberReferenceByJDEPartNumberDataSet FindPartNumberReferenceByJDEPartNumber(string strJDEPartNumber)
        {
            try
            {
                aFindPartNumberReferenceByJDEPartNumberDataSet = new FindPartNumberReferenceByJDEPartNumberDataSet();
                aFindPartNumberReferenceByJDEPartNumberTableAdapter = new FindPartNumberReferenceByJDEPartNumberDataSetTableAdapters.FindPartNumberReferenceByJDEPartNumberTableAdapter();
                aFindPartNumberReferenceByJDEPartNumberTableAdapter.Fill(aFindPartNumberReferenceByJDEPartNumberDataSet.FindPartNumberReferenceByJDEPartNumber, strJDEPartNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Find Part Number Reference By JDE Part Number " + Ex.Message);
            }

            return aFindPartNumberReferenceByJDEPartNumberDataSet;
        }
        public FindPartNumberReferenceByPartNumberDataSet FindPartNumberReferenceByPartNumber(string strPartNumber)
        {
            try
            {
                aFindPartNumberReferenceByPartNumberDataSet = new FindPartNumberReferenceByPartNumberDataSet();
                aFindPartNumberReferenceByPartNumberTableAdapter = new FindPartNumberReferenceByPartNumberDataSetTableAdapters.FindPartNumberReferenceByPartNumberTableAdapter();
                aFindPartNumberReferenceByPartNumberTableAdapter.Fill(aFindPartNumberReferenceByPartNumberDataSet.FindPartNumberReferenceByPartNumber, strPartNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Reference Class // Find Part Number Reference By Part Number " + Ex.Message);
            }

            return aFindPartNumberReferenceByPartNumberDataSet;
        }
        public bool UpdatePartNumberReferencePartID(int intTransactionID, int intPartID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdatePartNumberReferencePartIDTableAdapter = new UpdatePartNumberReferencePartIDTableAdapters.QueriesTableAdapter();
                aUpdatePartNumberReferencePartIDTableAdapter.UpdatePartNumberReferencePartID(intTransactionID, intPartID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Update Part Number Reference Part ID " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdatePartNumberReference(int intTransactionID, bool blnPartActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdatePartNumberReferenceActiveTableAdapter = new UpdatePartNumberReferernceActiveEntryTableAdapters.QueriesTableAdapter();
                aUpdatePartNumberReferenceActiveTableAdapter.UpdatePartNumberReferenceActive(intTransactionID, blnPartActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Update Part Number Reference " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertPartNumberReference(int intPartID, string strPartNumber, string strJDEPartNumber, int intEmployeeID, DateTime datTransactionDate, bool blnPartActive)
        {
            bool blnFatalError = true;

            try
            {
                aInsertPartNumberReferenceTableAdapter = new InsertPartNumberReferenceEntryTableAdapters.QueriesTableAdapter();
                aInsertPartNumberReferenceTableAdapter.InsertPartNumberReference(intPartID, strPartNumber, strJDEPartNumber, intEmployeeID, datTransactionDate, blnPartActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Part Number Main Class // Insert Part Number Reference " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
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
