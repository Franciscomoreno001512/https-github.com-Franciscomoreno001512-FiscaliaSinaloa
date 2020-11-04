using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Delito;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Delito
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class DelitoService : IDelitoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Delito.Delito> _DelitoRepository;
        #endregion

        #region Ctor
        public DelitoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Delito.Delito> DelitoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._DelitoRepository = DelitoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Delito.Delito> SelAll(bool ConRelaciones)
        {
            return this._DelitoRepository.Table.ToList();
        }

        public IList<Core.Domain.Delito.Delito> SelAllComplete(bool ConRelaciones)
        {
            return this._DelitoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Delito.Delito> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Delito.Delito> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Delito.Delito> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Delito.DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            DelitoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Delito.Delito> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Delito.Delito GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Delito.Delito result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Delito.Delito entity, Spartane.Core.Domain.User.GlobalData DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Delito.Delito entity, Spartane.Core.Domain.User.GlobalData DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

