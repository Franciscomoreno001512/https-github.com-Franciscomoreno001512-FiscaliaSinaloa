using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Control_de_Tiempos_JA;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Control_de_Tiempos_JA
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Control_de_Tiempos_JAService : IControl_de_Tiempos_JAService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA> _Control_de_Tiempos_JARepository;
        #endregion

        #region Ctor
        public Control_de_Tiempos_JAService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA> Control_de_Tiempos_JARepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Control_de_Tiempos_JARepository = Control_de_Tiempos_JARepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA> SelAll(bool ConRelaciones)
        {
            return this._Control_de_Tiempos_JARepository.Table.ToList();
        }

        public IList<Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA> SelAllComplete(bool ConRelaciones)
        {
            return this._Control_de_Tiempos_JARepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Control_de_Tiempos_JARepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Control_de_Tiempos_JARepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Control_de_Tiempos_JARepository.Table.ToList();
        }

        public Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JAPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Control_de_Tiempos_JAPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Control_de_Tiempos_JARepository.Table.ToList();
        }

        public Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Control_de_Tiempos_JAInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA entity, Spartane.Core.Domain.User.GlobalData Control_de_Tiempos_JAInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA entity, Spartane.Core.Domain.User.GlobalData Control_de_Tiempos_JAInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

