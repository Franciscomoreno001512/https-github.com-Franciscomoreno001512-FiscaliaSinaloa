using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Especialidad;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Especialidad
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class EspecialidadService : IEspecialidadService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Especialidad.Especialidad> _EspecialidadRepository;
        #endregion

        #region Ctor
        public EspecialidadService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Especialidad.Especialidad> EspecialidadRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._EspecialidadRepository = EspecialidadRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Especialidad.Especialidad> SelAll(bool ConRelaciones)
        {
            return this._EspecialidadRepository.Table.ToList();
        }

        public IList<Core.Domain.Especialidad.Especialidad> SelAllComplete(bool ConRelaciones)
        {
            return this._EspecialidadRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Especialidad.Especialidad> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._EspecialidadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Especialidad.Especialidad> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._EspecialidadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Especialidad.Especialidad> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._EspecialidadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Especialidad.EspecialidadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            EspecialidadPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Especialidad.Especialidad> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._EspecialidadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Especialidad.Especialidad GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Especialidad.Especialidad result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EspecialidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Especialidad.Especialidad entity, Spartane.Core.Domain.User.GlobalData EspecialidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Especialidad.Especialidad entity, Spartane.Core.Domain.User.GlobalData EspecialidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

