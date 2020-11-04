using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.A_Tiempo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.A_Tiempo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class A_TiempoService : IA_TiempoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.A_Tiempo.A_Tiempo> _A_TiempoRepository;
        #endregion

        #region Ctor
        public A_TiempoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.A_Tiempo.A_Tiempo> A_TiempoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._A_TiempoRepository = A_TiempoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> SelAll(bool ConRelaciones)
        {
            return this._A_TiempoRepository.Table.ToList();
        }

        public IList<Core.Domain.A_Tiempo.A_Tiempo> SelAllComplete(bool ConRelaciones)
        {
            return this._A_TiempoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._A_TiempoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._A_TiempoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._A_TiempoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.A_Tiempo.A_TiempoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            A_TiempoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._A_TiempoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.A_Tiempo.A_Tiempo GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.A_Tiempo.A_Tiempo result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData A_TiempoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.A_Tiempo.A_Tiempo entity, Spartane.Core.Domain.User.GlobalData A_TiempoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.A_Tiempo.A_Tiempo entity, Spartane.Core.Domain.User.GlobalData A_TiempoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

