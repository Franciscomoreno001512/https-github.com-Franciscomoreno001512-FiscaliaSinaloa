using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Periodicidad;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Periodicidad
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class PeriodicidadService : IPeriodicidadService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Periodicidad.Periodicidad> _PeriodicidadRepository;
        #endregion

        #region Ctor
        public PeriodicidadService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Periodicidad.Periodicidad> PeriodicidadRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._PeriodicidadRepository = PeriodicidadRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Periodicidad.Periodicidad> SelAll(bool ConRelaciones)
        {
            return this._PeriodicidadRepository.Table.ToList();
        }

        public IList<Core.Domain.Periodicidad.Periodicidad> SelAllComplete(bool ConRelaciones)
        {
            return this._PeriodicidadRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Periodicidad.Periodicidad> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PeriodicidadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Periodicidad.Periodicidad> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._PeriodicidadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Periodicidad.Periodicidad> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PeriodicidadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Periodicidad.PeriodicidadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            PeriodicidadPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Periodicidad.Periodicidad> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._PeriodicidadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Periodicidad.Periodicidad GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Periodicidad.Periodicidad result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData PeriodicidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Periodicidad.Periodicidad entity, Spartane.Core.Domain.User.GlobalData PeriodicidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Periodicidad.Periodicidad entity, Spartane.Core.Domain.User.GlobalData PeriodicidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

