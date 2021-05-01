using LabeledBread;
using UnityEngine;
using Zenject;

public class BreadFactoryManager : IInitializable
{
    private readonly Label.LabelBase.Factory _labelFactory;
    private readonly Bread.BreadBase.Factory _breadFactory;
    private readonly LabeledBreadBase.Factory _labeledBreadFactory;

    private Vector3 breadInitialPosition = new Vector3(0, 0, 0);

    public BreadFactoryManager(
        Label.LabelBase.Factory labelFactory,
        Bread.BreadBase.Factory breadFactory,
        LabeledBreadBase.Factory labeledBreadFactory
    )
    {
        _labelFactory = labelFactory;
        _breadFactory = breadFactory;
        _labeledBreadFactory = labeledBreadFactory;
    }

    public void CreateNewLabel(Label.Type type)
    {
        _labelFactory.Create(type);
    }

    public void CreateNewBread()
    {
        var newOne = _breadFactory.Create();
        newOne.transform.position = breadInitialPosition;
    }

    public void CreateNewLabeledBread(Label.Type labelType, Bread.Type breadType, Vector3 position)
    {
        var newOne = _labeledBreadFactory.Create(labelType, breadType);
        newOne.transform.position = position;
    }

    void IInitializable.Initialize()
    {
        CreateNewLabel(Label.Type.Cream);
        CreateNewLabel(Label.Type.Redbeans);
        CreateNewBread();
    }
}