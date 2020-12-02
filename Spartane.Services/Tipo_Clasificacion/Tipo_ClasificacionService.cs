using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_Clasificacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_Clasificacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_ClasificacionService : ITipo_ClasificacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> _Tipo_ClasificacionRepository;
        #endregion

        #region Ctor
        public Tipo_ClasificacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> Tipo_ClasificacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_ClasificacionRepository = Tipo_ClasificacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> SelAll(bool ConRelaciones)
        {
            return this._Tipo_ClasificacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_ClasificacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_ClasificacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_ClasificacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_ClasificacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Clasificacion.Tipo_ClasificacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_ClasificacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_ClasificacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_ClasificacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion entity, Spartane.Core.Domain.User.GlobalData Tipo_ClasificacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion entity, Spartane.Core.Domain.User.GlobalData Tipo_ClasificacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

