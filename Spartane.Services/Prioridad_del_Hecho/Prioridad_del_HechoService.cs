using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Prioridad_del_Hecho
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Prioridad_del_HechoService : IPrioridad_del_HechoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> _Prioridad_del_HechoRepository;
        #endregion

        #region Ctor
        public Prioridad_del_HechoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> Prioridad_del_HechoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Prioridad_del_HechoRepository = Prioridad_del_HechoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> SelAll(bool ConRelaciones)
        {
            return this._Prioridad_del_HechoRepository.Table.ToList();
        }

        public IList<Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> SelAllComplete(bool ConRelaciones)
        {
            return this._Prioridad_del_HechoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Prioridad_del_HechoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Prioridad_del_HechoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Prioridad_del_HechoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_HechoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Prioridad_del_HechoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Prioridad_del_HechoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Prioridad_del_HechoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho entity, Spartane.Core.Domain.User.GlobalData Prioridad_del_HechoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho entity, Spartane.Core.Domain.User.GlobalData Prioridad_del_HechoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

