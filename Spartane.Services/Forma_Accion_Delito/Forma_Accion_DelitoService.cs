using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Forma_Accion_Delito;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Forma_Accion_Delito
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Forma_Accion_DelitoService : IForma_Accion_DelitoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> _Forma_Accion_DelitoRepository;
        #endregion

        #region Ctor
        public Forma_Accion_DelitoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> Forma_Accion_DelitoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Forma_Accion_DelitoRepository = Forma_Accion_DelitoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> SelAll(bool ConRelaciones)
        {
            return this._Forma_Accion_DelitoRepository.Table.ToList();
        }

        public IList<Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> SelAllComplete(bool ConRelaciones)
        {
            return this._Forma_Accion_DelitoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Forma_Accion_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Forma_Accion_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Forma_Accion_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Forma_Accion_DelitoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Forma_Accion_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Forma_Accion_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito entity, Spartane.Core.Domain.User.GlobalData Forma_Accion_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito entity, Spartane.Core.Domain.User.GlobalData Forma_Accion_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

