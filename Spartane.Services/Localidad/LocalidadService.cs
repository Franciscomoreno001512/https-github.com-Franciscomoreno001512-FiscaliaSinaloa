using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Localidad;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Localidad
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class LocalidadService : ILocalidadService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Localidad.Localidad> _LocalidadRepository;
        #endregion

        #region Ctor
        public LocalidadService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Localidad.Localidad> LocalidadRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._LocalidadRepository = LocalidadRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Localidad.Localidad> SelAll(bool ConRelaciones)
        {
            return this._LocalidadRepository.Table.ToList();
        }

        public IList<Core.Domain.Localidad.Localidad> SelAllComplete(bool ConRelaciones)
        {
            return this._LocalidadRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Localidad.Localidad> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._LocalidadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Localidad.Localidad> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._LocalidadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Localidad.Localidad> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._LocalidadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Localidad.LocalidadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            LocalidadPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Localidad.Localidad> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._LocalidadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Localidad.Localidad GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Localidad.Localidad result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData LocalidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Localidad.Localidad entity, Spartane.Core.Domain.User.GlobalData LocalidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Localidad.Localidad entity, Spartane.Core.Domain.User.GlobalData LocalidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

