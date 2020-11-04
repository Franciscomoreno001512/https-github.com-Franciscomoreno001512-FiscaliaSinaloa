using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Motivo_de_No_Canalizacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Motivo_de_No_Canalizacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Motivo_de_No_CanalizacionService : IMotivo_de_No_CanalizacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion> _Motivo_de_No_CanalizacionRepository;
        #endregion

        #region Ctor
        public Motivo_de_No_CanalizacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion> Motivo_de_No_CanalizacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Motivo_de_No_CanalizacionRepository = Motivo_de_No_CanalizacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion> SelAll(bool ConRelaciones)
        {
            return this._Motivo_de_No_CanalizacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Motivo_de_No_CanalizacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Motivo_de_No_CanalizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Motivo_de_No_CanalizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Motivo_de_No_CanalizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_CanalizacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Motivo_de_No_CanalizacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Motivo_de_No_CanalizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Motivo_de_No_CanalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion entity, Spartane.Core.Domain.User.GlobalData Motivo_de_No_CanalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Motivo_de_No_Canalizacion.Motivo_de_No_Canalizacion entity, Spartane.Core.Domain.User.GlobalData Motivo_de_No_CanalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

