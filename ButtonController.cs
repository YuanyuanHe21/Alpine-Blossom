using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
private SpriteRenderer SR;

public Sprite defaltImage;
public Sprite pressedImage;

public KeyCode keyToPress;

void Start()
