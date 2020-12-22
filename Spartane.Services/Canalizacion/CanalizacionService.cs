using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Canalizacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Canalizacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class CanalizacionService : ICanalizacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Canalizacion.Canalizacion> _CanalizacionRepository;
        #endregion

        #region Ctor
        public CanalizacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Canalizacion.Canalizacion> CanalizacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._CanalizacionRepository = CanalizacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Canalizacion.Canalizacion> SelAll(bool ConRelaciones)
        {
            return this._CanalizacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Canalizacion.Canalizacion> SelAllComplete(bool ConRelaciones)
        {
            return this._CanalizacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Canalizacion.Canalizacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CanalizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Canalizacion.Canalizacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._CanalizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Canalizacion.Canalizacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CanalizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Canalizacion.CanalizacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            CanalizacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Canalizacion.Canalizacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._CanalizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Canalizacion.Canalizacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Canalizacion.Canalizacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData CanalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Canalizacion.Canalizacion entity, Spartane.Core.Domain.User.GlobalData CanalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Canalizacion.Canalizacion entity, Spartane.Core.Domain.User.GlobalData CanalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

