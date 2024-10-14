using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GamePresenter : IStartable
{
    readonly HelloWorldService helloWorldService;
    readonly HelloScreen helloScreen;

    [Inject]
    public GamePresenter(HelloWorldService helloWorldService, HelloScreen helloScreen)
    {
        this.helloWorldService = helloWorldService;
        this.helloScreen = helloScreen;
    }

    public void Start()
    {
        helloScreen.HelloButton.onClick.AddListener(() => helloWorldService.Hello());
    }
}
