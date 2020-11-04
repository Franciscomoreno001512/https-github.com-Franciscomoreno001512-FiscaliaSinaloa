using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Codigo_Postal;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Codigo_Postal
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Codigo_PostalService : ICodigo_PostalService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> _Codigo_PostalRepository;
        #endregion

        #region Ctor
        public Codigo_PostalService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> Codigo_PostalRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Codigo_PostalRepository = Codigo_PostalRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> SelAll(bool ConRelaciones)
        {
            return this._Codigo_PostalRepository.Table.ToList();
        }

        public IList<Core.Domain.Codigo_Postal.Codigo_Postal> SelAllComplete(bool ConRelaciones)
        {
            return this._Codigo_PostalRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Codigo_PostalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Codigo_PostalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Codigo_PostalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Codigo_Postal.Codigo_PostalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Codigo_PostalPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Codigo_PostalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Codigo_Postal.Codigo_Postal GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Codigo_Postal.Codigo_Postal result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Codigo_PostalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Codigo_Postal.Codigo_Postal entity, Spartane.Core.Domain.User.GlobalData Codigo_PostalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Codigo_Postal.Codigo_Postal entity, Spartane.Core.Domain.User.GlobalData Codigo_PostalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

