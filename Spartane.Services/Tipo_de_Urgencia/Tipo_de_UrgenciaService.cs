using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Urgencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Urgencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_UrgenciaService : ITipo_de_UrgenciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> _Tipo_de_UrgenciaRepository;
        #endregion

        #region Ctor
        public Tipo_de_UrgenciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> Tipo_de_UrgenciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_UrgenciaRepository = Tipo_de_UrgenciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_UrgenciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_UrgenciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_UrgenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_UrgenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_UrgenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_UrgenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_UrgenciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_UrgenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_de_UrgenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia entity, Spartane.Core.Domain.User.GlobalData Tipo_de_UrgenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia entity, Spartane.Core.Domain.User.GlobalData Tipo_de_UrgenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

