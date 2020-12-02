using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Pirateria;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Pirateria
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_PirateriaService : ITipo_de_PirateriaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria> _Tipo_de_PirateriaRepository;
        #endregion

        #region Ctor
        public Tipo_de_PirateriaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria> Tipo_de_PirateriaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_PirateriaRepository = Tipo_de_PirateriaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_PirateriaRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_PirateriaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_PirateriaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_PirateriaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_PirateriaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_PirateriaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_PirateriaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_PirateriaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Tipo_de_PirateriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria entity, Spartane.Core.Domain.User.GlobalData Tipo_de_PirateriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria entity, Spartane.Core.Domain.User.GlobalData Tipo_de_PirateriaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

