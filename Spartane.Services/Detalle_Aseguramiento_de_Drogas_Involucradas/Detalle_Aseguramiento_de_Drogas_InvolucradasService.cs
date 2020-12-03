using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Aseguramiento_de_Drogas_Involucradas
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Aseguramiento_de_Drogas_InvolucradasService : IDetalle_Aseguramiento_de_Drogas_InvolucradasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas> _Detalle_Aseguramiento_de_Drogas_InvolucradasRepository;
        #endregion

        #region Ctor
        public Detalle_Aseguramiento_de_Drogas_InvolucradasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas> Detalle_Aseguramiento_de_Drogas_InvolucradasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Aseguramiento_de_Drogas_InvolucradasRepository = Detalle_Aseguramiento_de_Drogas_InvolucradasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_de_Drogas_InvolucradasRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_de_Drogas_InvolucradasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_de_Drogas_InvolucradasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Aseguramiento_de_Drogas_InvolucradasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_de_Drogas_InvolucradasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_InvolucradasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Aseguramiento_de_Drogas_InvolucradasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Aseguramiento_de_Drogas_InvolucradasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_de_Drogas_InvolucradasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_de_Drogas_InvolucradasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas.Detalle_Aseguramiento_de_Drogas_Involucradas entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_de_Drogas_InvolucradasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

