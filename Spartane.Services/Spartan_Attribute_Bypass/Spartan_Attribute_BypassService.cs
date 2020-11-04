using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Spartan_Attribute_Bypass;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Spartan_Attribute_Bypass
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Spartan_Attribute_BypassService : ISpartan_Attribute_BypassService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass> _Spartan_Attribute_BypassRepository;
        #endregion

        #region Ctor
        public Spartan_Attribute_BypassService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass> Spartan_Attribute_BypassRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Spartan_Attribute_BypassRepository = Spartan_Attribute_BypassRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass> SelAll(bool ConRelaciones)
        {
            return this._Spartan_Attribute_BypassRepository.Table.ToList();
        }

        public IList<Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass> SelAllComplete(bool ConRelaciones)
        {
            return this._Spartan_Attribute_BypassRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Spartan_Attribute_BypassRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Spartan_Attribute_BypassRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Spartan_Attribute_BypassRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_BypassPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Spartan_Attribute_BypassPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Spartan_Attribute_BypassRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Spartan_Attribute_BypassInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass entity, Spartane.Core.Domain.User.GlobalData Spartan_Attribute_BypassInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass entity, Spartane.Core.Domain.User.GlobalData Spartan_Attribute_BypassInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

