using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Agravantes_del_Delito;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Agravantes_del_Delito
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Agravantes_del_DelitoService : IAgravantes_del_DelitoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito> _Agravantes_del_DelitoRepository;
        #endregion

        #region Ctor
        public Agravantes_del_DelitoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito> Agravantes_del_DelitoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Agravantes_del_DelitoRepository = Agravantes_del_DelitoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito> SelAll(bool ConRelaciones)
        {
            return this._Agravantes_del_DelitoRepository.Table.ToList();
        }

        public IList<Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito> SelAllComplete(bool ConRelaciones)
        {
            return this._Agravantes_del_DelitoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Agravantes_del_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Agravantes_del_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Agravantes_del_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Agravantes_del_DelitoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Agravantes_del_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Agravantes_del_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito entity, Spartane.Core.Domain.User.GlobalData Agravantes_del_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito entity, Spartane.Core.Domain.User.GlobalData Agravantes_del_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

