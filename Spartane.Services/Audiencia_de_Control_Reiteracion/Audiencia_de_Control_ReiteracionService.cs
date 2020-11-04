using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Audiencia_de_Control_Reiteracion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Audiencia_de_Control_Reiteracion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Audiencia_de_Control_ReiteracionService : IAudiencia_de_Control_ReiteracionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion> _Audiencia_de_Control_ReiteracionRepository;
        #endregion

        #region Ctor
        public Audiencia_de_Control_ReiteracionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion> Audiencia_de_Control_ReiteracionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Audiencia_de_Control_ReiteracionRepository = Audiencia_de_Control_ReiteracionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion> SelAll(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_ReiteracionRepository.Table.ToList();
        }

        public IList<Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion> SelAllComplete(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_ReiteracionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_ReiteracionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Audiencia_de_Control_ReiteracionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_ReiteracionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_ReiteracionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Audiencia_de_Control_ReiteracionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Audiencia_de_Control_ReiteracionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_ReiteracionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_ReiteracionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_ReiteracionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

