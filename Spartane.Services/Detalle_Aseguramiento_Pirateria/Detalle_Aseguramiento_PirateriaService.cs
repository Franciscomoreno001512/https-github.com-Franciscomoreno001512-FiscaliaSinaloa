using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Aseguramiento_Pirateria
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Aseguramiento_PirateriaService : IDetalle_Aseguramiento_PirateriaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria> _Detalle_Aseguramiento_PirateriaRepository;
        #endregion

        #region Ctor
        public Detalle_Aseguramiento_PirateriaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria> Detalle_Aseguramiento_PirateriaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Aseguramiento_PirateriaRepository = Detalle_Aseguramiento_PirateriaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_PirateriaRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_PirateriaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_PirateriaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Aseguramiento_PirateriaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_PirateriaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_PirateriaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Aseguramiento_PirateriaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Aseguramiento_PirateriaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_PirateriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_PirateriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria.Detalle_Aseguramiento_Pirateria entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_PirateriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

