using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Audiencia_de_Control_Hechos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Audiencia_de_Control_Hechos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Audiencia_de_Control_HechosService : IAudiencia_de_Control_HechosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos> _Audiencia_de_Control_HechosRepository;
        #endregion

        #region Ctor
        public Audiencia_de_Control_HechosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos> Audiencia_de_Control_HechosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Audiencia_de_Control_HechosRepository = Audiencia_de_Control_HechosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos> SelAll(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_HechosRepository.Table.ToList();
        }

        public IList<Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos> SelAllComplete(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_HechosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_HechosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Audiencia_de_Control_HechosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_HechosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_HechosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Audiencia_de_Control_HechosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Audiencia_de_Control_HechosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_HechosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_HechosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_HechosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

