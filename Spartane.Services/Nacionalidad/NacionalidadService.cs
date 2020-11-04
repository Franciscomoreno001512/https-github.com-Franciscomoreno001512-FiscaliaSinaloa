using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Nacionalidad;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Nacionalidad
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class NacionalidadService : INacionalidadService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Nacionalidad.Nacionalidad> _NacionalidadRepository;
        #endregion

        #region Ctor
        public NacionalidadService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Nacionalidad.Nacionalidad> NacionalidadRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._NacionalidadRepository = NacionalidadRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> SelAll(bool ConRelaciones)
        {
            return this._NacionalidadRepository.Table.ToList();
        }

        public IList<Core.Domain.Nacionalidad.Nacionalidad> SelAllComplete(bool ConRelaciones)
        {
            return this._NacionalidadRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._NacionalidadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._NacionalidadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._NacionalidadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Nacionalidad.NacionalidadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            NacionalidadPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._NacionalidadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Nacionalidad.Nacionalidad GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Nacionalidad.Nacionalidad result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData NacionalidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Nacionalidad.Nacionalidad entity, Spartane.Core.Domain.User.GlobalData NacionalidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Nacionalidad.Nacionalidad entity, Spartane.Core.Domain.User.GlobalData NacionalidadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

