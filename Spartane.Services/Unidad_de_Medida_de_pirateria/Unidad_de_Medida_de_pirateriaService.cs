using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Unidad_de_Medida_de_pirateria;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Unidad_de_Medida_de_pirateria
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Unidad_de_Medida_de_pirateriaService : IUnidad_de_Medida_de_pirateriaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> _Unidad_de_Medida_de_pirateriaRepository;
        #endregion

        #region Ctor
        public Unidad_de_Medida_de_pirateriaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> Unidad_de_Medida_de_pirateriaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Unidad_de_Medida_de_pirateriaRepository = Unidad_de_Medida_de_pirateriaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> SelAll(bool ConRelaciones)
        {
            return this._Unidad_de_Medida_de_pirateriaRepository.Table.ToList();
        }

        public IList<Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> SelAllComplete(bool ConRelaciones)
        {
            return this._Unidad_de_Medida_de_pirateriaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Unidad_de_Medida_de_pirateriaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Unidad_de_Medida_de_pirateriaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Unidad_de_Medida_de_pirateriaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateriaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Unidad_de_Medida_de_pirateriaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Unidad_de_Medida_de_pirateriaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Unidad_de_Medida_de_pirateriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria entity, Spartane.Core.Domain.User.GlobalData Unidad_de_Medida_de_pirateriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria entity, Spartane.Core.Domain.User.GlobalData Unidad_de_Medida_de_pirateriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

