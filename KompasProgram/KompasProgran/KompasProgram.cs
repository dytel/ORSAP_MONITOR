using System;
using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using MonitorSettings;

namespace KompasPrograms
{
    /// <summary>
    /// Класс создающий 3Д модель монитор
    /// </summary>
    public class KompasProgram
    {
        /// <summary>
        /// Параметры монитора
        /// </summary>
        private MonitorSetting _monitorSetting = new MonitorSetting();

        /// <summary>
        /// Объект компаса
        /// </summary>
        private KompasObject _kompasObject;

        /// <summary>
        /// Объект 3д Документа
        /// </summary>
        private ksDocument3D _ksDocument3D;

        /// <summary>
        /// Объект детали
        /// </summary>
        private ksPart _ksPart;

        /// <summary>
        /// Дополнительная высота
        /// </summary>
        private const int _additionalHeight = 70;

        /// <summary>
        /// Дополнительная ширина
        /// </summary>
        private const int _additionalWight = 50;

        /// <summary>
        /// Запуск компаса
        /// </summary>
        private void RunningTheCompas()
        {
            if (_kompasObject != null)
            {
                _kompasObject.ActivateControllerAPI();

            }
            if (_kompasObject == null)
            {
                Type type = Type.GetTypeFromProgID("KOMPAS.Application.5");
                _kompasObject = (KompasObject)Activator.CreateInstance(type);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings">Параметры монитора</param>
        public void SetParametr(MonitorSetting settings)
        {
            _monitorSetting = settings;
        }

        /// <summary>
        /// Создание Нового 3Д документа
        /// </summary>
        private void CreateANewDocument()
        {
            _ksDocument3D = (ksDocument3D)_kompasObject.Document3D();
            _ksDocument3D.Create();
        }

        /// <summary>
        /// Получение интерфеса компонента
        /// </summary>
        private void GetTheComponentInterface()
        {
            const int pTop_Part = -1;
            _ksPart = (ksPart)_ksDocument3D.GetPart(pTop_Part);
        }

        /// <summary>
        /// Создание Эскиза
        /// </summary>
        /// <param name="part">Деталь</param>
        /// <param name="ksEntityDrawStande">Эскиз детали</param>
        /// <param name="ksEntityPlaneOffset">Сдвиг эскиза</param>
        private void CreatSketchThree(ksPart part, ksEntity ksEntityDrawStande,
            ksEntity ksEntityPlaneOffset)
        {
            ksSketchDefinition ksSketchDefinition;
            ksDocument2D _ksDocument2D;
            ksEntity ksEntityPlane;
            ksSketchDefinition = (ksSketchDefinition)ksEntityDrawStande.GetDefinition();
            ksEntityPlane = (ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            ksSketchDefinition.SetPlane(ksEntityPlaneOffset);
            ksEntityDrawStande.Create();
            ksRectangleParam ksRectangleParam;
            ksRectangleParam = (ksRectangleParam)_kompasObject.GetParamStruct(
                (int)StructType2DEnum.ko_RectangleParam);
            ksRectangleParam.ang = 0;
            ksRectangleParam.height = _monitorSetting.StandHeight;
            ksRectangleParam.width = _monitorSetting.StandeWight;
            ksRectangleParam.style = 1;
            ksRectangleParam.x = (_monitorSetting.MonitorWight + _additionalWight)
                / 2 - (_monitorSetting.StandeWight / 2);
            ksRectangleParam.y = _monitorSetting.MonitorHeight / 2;
            _ksDocument2D = (ksDocument2D)ksSketchDefinition.BeginEdit();
            _ksDocument2D.ksRectangle(ksRectangleParam, 0);
            ksSketchDefinition.EndEdit();
        }

        /// <summary>
        /// Выдваливание
        /// </summary>
        /// <param name="size">размер</param>
        /// <param name="ksEntity">эскиз</param>
        /// <param name="name">Назавание</param>
        /// <param name="ksEntityExtrusion">Элемент выдавливания</param>
        private void Exstrusion(double size, ksEntity ksEntity,
            string name, ksEntity ksEntityExtrusion)
        {
            const int grayColor = 3223857;
            ksEntityExtrusion = (ksEntity)_ksPart.NewEntity((int)Obj3dType.o3d_baseExtrusion);
            ksBaseExtrusionDefinition ksBaseExtrusionDefinition =
                (ksBaseExtrusionDefinition)ksEntityExtrusion.GetDefinition();
            ksBaseExtrusionDefinition.SetSideParam(true, (short)End_Type.etBlind,
                size, 0, true);
            ksBaseExtrusionDefinition.SetSketch(ksEntity);
            ksEntityExtrusion.name = name;
            ksEntityExtrusion.useColor = 0;
            ksEntityExtrusion.SetAdvancedColor(grayColor, 0.9, 0.8, 0.7, 0.6, 1, 0.4);
            ksEntityExtrusion.Create();
        }

        /// <summary>
        /// Создание эскиза
        /// </summary>
        /// <param name="part">Деталь</param>
        /// <param name="ksEntityDraw">Эскиз</param>
        private void CreatSketch(ksPart part, ksEntity ksEntityDraw)
        {
            ksSketchDefinition ksSketchDefinition;
            ksDocument2D _ksDocument2D;
            ksEntity ksEntityPlane;
            ksSketchDefinition = (ksSketchDefinition)ksEntityDraw.GetDefinition();
            ksEntityPlane = (ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            ksSketchDefinition.SetPlane(ksEntityPlane);
            ksEntityDraw.Create();
            ksRectangleParam ksRectangleParam;
            ksRectangleParam = (ksRectangleParam)_kompasObject.GetParamStruct(
                (int)StructType2DEnum.ko_RectangleParam);
            ksRectangleParam.ang = 0;
            ksRectangleParam.height = _monitorSetting.MonitorHeight + _additionalHeight;
            ksRectangleParam.width = _monitorSetting.MonitorWight + _additionalWight;
            ksRectangleParam.style = 1;
            ksRectangleParam.x = 0;
            ksRectangleParam.y = 0;
            _ksDocument2D = (ksDocument2D)ksSketchDefinition.BeginEdit();
            _ksDocument2D.ksRectangle(ksRectangleParam, 0);
            ksSketchDefinition.EndEdit();
        }

        /// <summary>
        /// Создание эскиза
        /// </summary>
        /// <param name="part">деталь</param>
        /// <param name="ksEntityCircle">эскиз</param>
        /// <param name="ksEntityPlaneOffset">сдвиг плоскости</param>
        private void CreatSketchCircle(ksPart part,
            ksEntity ksEntityCircle, ksEntity ksEntityPlaneOffset)
        {
            ksSketchDefinition ksSketchDefinition;
            ksDocument2D _ksDocument2D;
            ksEntity ksEntityPlane;
            ksSketchDefinition = (ksSketchDefinition)ksEntityCircle.GetDefinition();
            ksEntityPlane = (ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            ksSketchDefinition.SetPlane(ksEntityPlaneOffset);
            ksEntityCircle.Create();
            _ksDocument2D = (ksDocument2D)ksSketchDefinition.BeginEdit();
            _ksDocument2D.ksCircle(_monitorSetting.MonitorWight / 2 + _monitorSetting.Radius / 8,
               -90, _monitorSetting.Radius, 1);
            ksSketchDefinition.EndEdit();
        }

        /// <summary>
        /// Создание эскиза
        /// </summary>
        /// <param name="part">Деталь</param>
        /// <param name="ksEntityDrawTwo">эскиз</param>
        private void CreatSketchTwo(ksPart part, ksEntity ksEntityDrawTwo)
        {
            ksSketchDefinition _ksSketchDefinition;
            ksDocument2D _ksDocument2D;
            ksEntity ksEntityPlane;
            _ksSketchDefinition = (ksSketchDefinition)ksEntityDrawTwo.GetDefinition();
            ksEntityPlane = (ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            _ksSketchDefinition.SetPlane(ksEntityPlane);
            ksEntityDrawTwo.Create();
            ksRectangleParam ksRectangleParam;
            ksRectangleParam = (ksRectangleParam)_kompasObject.GetParamStruct(
                (int)StructType2DEnum.ko_RectangleParam);
            ksRectangleParam.ang = 0;
            ksRectangleParam.height = _monitorSetting.MonitorHeight;
            ksRectangleParam.width = _monitorSetting.MonitorWight;
            ksRectangleParam.style = 1;
            ksRectangleParam.x = 25;
            ksRectangleParam.y = 35;
            _ksDocument2D = (ksDocument2D)_ksSketchDefinition.BeginEdit();
            _ksDocument2D.ksRectangle(ksRectangleParam, 0);
            _ksSketchDefinition.EndEdit();
        }

        /// <summary>
        /// Выдавливание вырезанием
        /// </summary>
        /// <param name=""="name">Название</param>
        /// <param name="ksEntityExtrusion">элемент выдавливания</param>
        /// <param name="ksEntityDrawTwo">эскиз</param>        
        private void ExstrusionCut(string name, ksEntity ksEntityExtrusion, ksEntity ksEntityDrawTwo)
        {
            ksCutExtrusionDefinition _ksCutExtrusionDefinition = 
                (ksCutExtrusionDefinition)ksEntityExtrusion.GetDefinition();
            _ksCutExtrusionDefinition.SetSideParam(true, (short)End_Type.etBlind, 10, 0, true);
            _ksCutExtrusionDefinition.SetSketch(ksEntityDrawTwo);
            ksEntityExtrusion.name = name;
            ksEntityExtrusion.useColor = 0;
            ksEntityExtrusion.SetAdvancedColor(0, 0.9, 0.8, 0.7, 0.6, 1, 0.4);
            ksEntityExtrusion.Create();
        }

        /// <summary>
        /// Создание смещёной плоскости
        /// </summary>
        /// <param name="offset">сдвиг</param>
        /// <param name="plane">плоскость</param>
        /// <param name="ksEntityPlaneOffset">сдвиг плосости</param>
        private void CreatPlaneOffset(double offset, short plane, ksEntity ksEntityPlaneOffset)
        {
            ksEntity ksEntityPlaneXOY = (ksEntity)_ksPart.GetDefaultEntity(plane);
            ksPlaneOffsetDefinition ksPlaneOffsetDefinition =
                (ksPlaneOffsetDefinition)ksEntityPlaneOffset.GetDefinition();
            ksPlaneOffsetDefinition.SetPlane(ksEntityPlaneXOY);
            ksPlaneOffsetDefinition.direction = true;
            ksPlaneOffsetDefinition.offset = offset;
            ksEntityPlaneOffset.Create();
        }

        /// <summary>
        /// Постоение детали
        /// </summary>      
        public void Construct()
        {
            RunningTheCompas();
            CreateANewDocument();
            GetTheComponentInterface();
            ksEntity ksEntityDraw = (ksEntity)_ksPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksEntity ksEntityDrawTwo = (ksEntity)_ksPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksEntity ksEntityPlaneOffset = (ksEntity)_ksPart.NewEntity(
                (short)Obj3dType.o3d_planeOffset);
            ksEntity ksEntityExtrusion = (ksEntity)_ksPart.NewEntity(
                (short)Obj3dType.o3d_cutExtrusion);
            ksEntity ksEntityCircle = (ksEntity)_ksPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksEntity ksEntityDrawStande = (ksEntity)_ksPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksEntity ksEntityPlaneOffsetTwo = (ksEntity)_ksPart.NewEntity(
                (short)Obj3dType.o3d_planeOffset);
            CreatSketch(_ksPart, ksEntityDraw);
            Exstrusion(50, ksEntityDraw, "Выдавливание 1", ksEntityExtrusion);
            CreatSketchTwo(_ksPart, ksEntityDrawTwo);
            ExstrusionCut("Выдавливание вырезанием", ksEntityExtrusion,
                ksEntityDrawTwo);
            CreatPlaneOffset(50, (short)Obj3dType.o3d_planeXOY, ksEntityPlaneOffsetTwo);
            CreatSketchThree(_ksPart, ksEntityDrawStande, ksEntityPlaneOffsetTwo);
            Exstrusion(70, ksEntityDrawStande, "Выдавливание 2", ksEntityExtrusion);
            CreatPlaneOffset(_monitorSetting.MonitorHeight / 2 
                + _monitorSetting.StandHeight,
                (short)Obj3dType.o3d_planeXOZ, ksEntityPlaneOffset);
            CreatSketchCircle(_ksPart, ksEntityCircle, ksEntityPlaneOffset);
            Exstrusion(20, ksEntityCircle, "Выдавливание 3", ksEntityExtrusion);
            _kompasObject.Visible = true;
        }
    }
}