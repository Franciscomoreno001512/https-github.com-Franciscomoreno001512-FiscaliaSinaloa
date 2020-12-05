using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Resultado_de_Audiencia_Intermedia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Resultado_de_Audiencia_IntermediaService : IResultado_de_Audiencia_IntermediaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia> _Resultado_de_Audiencia_IntermediaRepository;
        #endregion

        #region Ctor
        public Resultado_de_Audiencia_IntermediaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia> Resultado_de_Audiencia_IntermediaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Resultado_de_Audiencia_IntermediaRepository = Resultado_de_Audiencia_IntermediaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia> SelAll(bool ConRelaciones)
        {
            return this._Resultado_de_Audiencia_IntermediaRepository.Table.ToList();
        }

        public IList<Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia> SelAllComplete(bool ConRelaciones)
        {
            return this._Resultado_de_Audiencia_IntermediaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resultado_de_Audiencia_IntermediaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Resultado_de_Audiencia_IntermediaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resultado_de_Audiencia_IntermediaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_IntermediaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Resultado_de_Audiencia_IntermediaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Resultado_de_Audiencia_IntermediaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Resultado_de_Audiencia_IntermediaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia entity, Spartane.Core.Domain.User.GlobalData Resultado_de_Audiencia_IntermediaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia entity, Spartane.Core.Domain.User.GlobalData Resultado_de_Audiencia_IntermediaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

