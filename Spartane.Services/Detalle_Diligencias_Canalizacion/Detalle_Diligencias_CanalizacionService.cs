using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Diligencias_Canalizacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Diligencias_Canalizacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Diligencias_CanalizacionService : IDetalle_Diligencias_CanalizacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> _Detalle_Diligencias_CanalizacionRepository;
        #endregion

        #region Ctor
        public Detalle_Diligencias_CanalizacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> Detalle_Diligencias_CanalizacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Diligencias_CanalizacionRepository = Detalle_Diligencias_CanalizacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Diligencias_CanalizacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Diligencias_CanalizacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Diligencias_CanalizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Diligencias_CanalizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Diligencias_CanalizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_CanalizacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Diligencias_CanalizacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Diligencias_CanalizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Diligencias_CanalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion entity, Spartane.Core.Domain.User.GlobalData Detalle_Diligencias_CanalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion entity, Spartane.Core.Domain.User.GlobalData Detalle_Diligencias_CanalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

