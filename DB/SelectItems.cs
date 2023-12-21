﻿using Dou.Misc.Attr;
using FtisHelperDrawGame.DB.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FtisHelperDrawGame.DB
{
    public class EmpSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperDrawGame.DB.EmpSelectItemsClassImp, FtisHelperDrawGame";

        protected static IEnumerable<F22cmmEmpData> _emps;
        protected static new IEnumerable<F22cmmEmpData> EMPS
        {
            get
            {
                _emps = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpData>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_emps == null)
                {
                    _emps = Helpe.Employee.GetAllEmployee().Where(s => s.Quit == false);// && s.Fno=="F01721");
                    DouHelper.Misc.AddCache(_emps, AssemblyQualifiedName);
                }
                return _emps;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return EMPS.Select(s => new KeyValuePair<string, object>(s.Fno, "{\"v\":\"" + s.Name + "\",\"dcode\":\"" + s.DCode + "\"}"));
        }
    }
    public class EmpSelectAllItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperDrawGame.DB.EmpSelectItemsClassImp, FtisHelperDrawGame";

        protected static IEnumerable<F22cmmEmpData> _emps;
        protected static new IEnumerable<F22cmmEmpData> EMPS
        {
            get
            {
                _emps = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpData>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_emps == null)
                {
                    _emps = Helpe.Employee.GetAllEmployee();// && s.Fno=="F01721");
                    DouHelper.Misc.AddCache(_emps, AssemblyQualifiedName);
                }
                return _emps;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return EMPS.Select(s => new KeyValuePair<string, object>(s.Fno, "{\"v\":\"" + s.Name + "\",\"dcode\":\"" + s.DCode + "\"}"));
        }
    }
    public class DepartmentSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperDrawGame.DB.DepartmentSelectItemsClassImp, FtisHelperDrawGame";

        protected static IEnumerable<F22cmmDep> _deps;
        protected static new IEnumerable<F22cmmDep> DEPS
        {
            get
            {
                _deps = DouHelper.Misc.GetCache<IEnumerable<F22cmmDep>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_deps == null)
                {
                    _deps = Helpe.Department.GetAllDepartment().Where(s => s.IsUsed == "Y");
                    DouHelper.Misc.AddCache(_deps, AssemblyQualifiedName);
                }
                return _deps;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return DEPS.Select(s => new KeyValuePair<string, object>(s.DCode, s.DName));
        }
    }
}
