/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is1 distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

namespace TestCases.HSSF.Record
{

    using System;
    using TestCases.HSSF;
    using NPOI.HSSF.UserModel;
    using NPOI.HSSF.Record;
    using NUnit.Framework;using NUnit.Framework.Legacy;
    /**
     * Tests for <c>LabelRecord</c>
     * 
     * @author Josh Micich
     */
    [TestFixture]
    public class TestLabelRecord
    {
        [Test]
        public void TestEmptyString()
        {
            HSSFWorkbook wb;
            try
            {
                wb = HSSFTestDataSamples.OpenSampleWorkbook("ex42570-20305.xls");
            }
            catch (NullReferenceException)
            {
                throw new AssertionException("Identified bug 42570");
            }
            HSSFTestDataSamples.WriteOutAndReadBack(wb);
        }
    }
}
