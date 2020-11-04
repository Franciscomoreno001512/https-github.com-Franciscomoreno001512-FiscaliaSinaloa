using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Ocupacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Ocupacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class OcupacionService : IOcupacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Ocupacion.Ocupacion> _OcupacionRepository;
        #endregion

        #region Ctor
        public OcupacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Ocupacion.Ocupacion> OcupacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._OcupacionRepository = OcupacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Ocupacion.Ocupacion> SelAll(bool ConRelaciones)
        {
            return this._OcupacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Ocupacion.Ocupacion> SelAllComplete(bool ConRelaciones)
        {
            return this._OcupacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Ocupacion.Ocupacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._OcupacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ocupacion.Ocupacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._OcupacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ocupacion.Ocupacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._OcupacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ocupacion.OcupacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            OcupacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Ocupacion.Ocupacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._OcupacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ocupacion.Ocupacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Ocupacion.Ocupacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData OcupacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Ocupacion.Ocupacion entity, Spartane.Core.Domain.User.GlobalData OcupacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Ocupacion.Ocupacion entity, Spartane.Core.Domain.User.GlobalData OcupacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

