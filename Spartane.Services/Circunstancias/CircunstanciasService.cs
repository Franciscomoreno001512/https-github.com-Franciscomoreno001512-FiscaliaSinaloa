using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Circunstancias;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Circunstancias
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class CircunstanciasService : ICircunstanciasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Circunstancias.Circunstancias> _CircunstanciasRepository;
        #endregion

        #region Ctor
        public CircunstanciasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Circunstancias.Circunstancias> CircunstanciasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._CircunstanciasRepository = CircunstanciasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Circunstancias.Circunstancias> SelAll(bool ConRelaciones)
        {
            return this._CircunstanciasRepository.Table.ToList();
        }

        public IList<Core.Domain.Circunstancias.Circunstancias> SelAllComplete(bool ConRelaciones)
        {
            return this._CircunstanciasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Circunstancias.Circunstancias> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CircunstanciasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Circunstancias.Circunstancias> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._CircunstanciasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Circunstancias.Circunstancias> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CircunstanciasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Circunstancias.CircunstanciasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            CircunstanciasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Circunstancias.Circunstancias> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._CircunstanciasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Circunstancias.Circunstancias GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Circunstancias.Circunstancias result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData CircunstanciasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Circunstancias.Circunstancias entity, Spartane.Core.Domain.User.GlobalData CircunstanciasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Circunstancias.Circunstancias entity, Spartane.Core.Domain.User.GlobalData CircunstanciasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

