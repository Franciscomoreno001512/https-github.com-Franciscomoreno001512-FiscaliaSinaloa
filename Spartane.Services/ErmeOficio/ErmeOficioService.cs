using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.ErmeOficio;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.ErmeOficio
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class ErmeOficioService : IErmeOficioService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.ErmeOficio.ErmeOficio> _ErmeOficioRepository;
        #endregion

        #region Ctor
        public ErmeOficioService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.ErmeOficio.ErmeOficio> ErmeOficioRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._ErmeOficioRepository = ErmeOficioRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> SelAll(bool ConRelaciones)
        {
            return this._ErmeOficioRepository.Table.ToList();
        }

        public IList<Core.Domain.ErmeOficio.ErmeOficio> SelAllComplete(bool ConRelaciones)
        {
            return this._ErmeOficioRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ErmeOficioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._ErmeOficioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ErmeOficioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.ErmeOficio.ErmeOficioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            ErmeOficioPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._ErmeOficioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.ErmeOficio.ErmeOficio GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.ErmeOficio.ErmeOficio result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData ErmeOficioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.ErmeOficio.ErmeOficio entity, Spartane.Core.Domain.User.GlobalData ErmeOficioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.ErmeOficio.ErmeOficio entity, Spartane.Core.Domain.User.GlobalData ErmeOficioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

