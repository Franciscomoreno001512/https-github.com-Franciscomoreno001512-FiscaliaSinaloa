using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Grupo_al_que_Pertenece;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Grupo_al_que_Pertenece
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Grupo_al_que_PerteneceService : IGrupo_al_que_PerteneceService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> _Grupo_al_que_PerteneceRepository;
        #endregion

        #region Ctor
        public Grupo_al_que_PerteneceService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> Grupo_al_que_PerteneceRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Grupo_al_que_PerteneceRepository = Grupo_al_que_PerteneceRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> SelAll(bool ConRelaciones)
        {
            return this._Grupo_al_que_PerteneceRepository.Table.ToList();
        }

        public IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> SelAllComplete(bool ConRelaciones)
        {
            return this._Grupo_al_que_PerteneceRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Grupo_al_que_PerteneceRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Grupo_al_que_PerteneceRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Grupo_al_que_PerteneceRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_PertenecePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Grupo_al_que_PertenecePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Grupo_al_que_PerteneceRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Grupo_al_que_PerteneceInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece entity, Spartane.Core.Domain.User.GlobalData Grupo_al_que_PerteneceInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece entity, Spartane.Core.Domain.User.GlobalData Grupo_al_que_PerteneceInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

