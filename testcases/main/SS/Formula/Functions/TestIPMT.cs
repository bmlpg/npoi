﻿/*
 *  ====================================================================
 *    Licensed to the Apache Software Foundation (ASF) under one or more
 *    contributor license agreements.  See the NOTICE file distributed with
 *    this work for Additional information regarding copyright ownership.
 *    The ASF licenses this file to You under the Apache License, Version 2.0
 *    (the "License"); you may not use this file except in compliance with
 *    the License.  You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 * ====================================================================
 */

namespace TestCases.SS.Formula.Functions
{
    using NPOI.HSSF.UserModel;
    using NPOI.SS.UserModel;
    using NUnit.Framework;using NUnit.Framework.Legacy;
    using TestCases.HSSF;

    /**
     * Test cases for IPMT()
     *
     */
    [TestFixture]
    public class TestIPMT
    {


        /**
         *  from http://office.microsoft.com/en-001/excel-help/ipmt-HP005209145.aspx
         */
        [Test]
        public void TestFromFile()
        {

            HSSFWorkbook wb = HSSFTestDataSamples.OpenSampleWorkbook("finance.xls");
            HSSFFormulaEvaluator fe = new HSSFFormulaEvaluator(wb);

            ISheet example1 = wb.GetSheet("IPMT");
            ICell ex1cell1 = example1.GetRow(6).GetCell(0);
            fe.Evaluate(ex1cell1);
            ClassicAssert.AreEqual(-22.41, ex1cell1.NumericCellValue, 0.1);

            ICell ex1cell2 = example1.GetRow(7).GetCell(0);
            fe.Evaluate(ex1cell2);
            ClassicAssert.AreEqual(-292.45, ex1cell2.NumericCellValue, 0.1);

        }
    }

}