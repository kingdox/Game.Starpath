using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MMA;
using TMPro;

public class UI_Setup : Module
{
    [Header("Header")]
    [Space]
    [SerializeField] private TMP_Text tmp_text_title = default;

    [Header("Nickname")]
    [Space]
    [SerializeField] private TMP_Text tmp_text_input_name_placeholder = default;
    [SerializeField] private TMP_InputField tmp_inputfield = default;

    [Header("Color")]
    [Space]
    [SerializeField] private Transform tr_parent_ui_color = default;
    [SerializeField] private UI_Component_Color pref_ui_color = default;

    [Header("Bottom")]
    [Space]
    [SerializeField] private Button btn_continue = default;
    [SerializeField] private TMP_Text tmp_text_button_continue = default;

    private void Start()
    {
        OnTranslateUI();
    }

    protected override void OnSubscription(bool condition)
    {
        //OnTranslateUI
        Middleware.Subscribe_Publish(condition, MMA.Localization.Key.OnSetStringTable, OnTranslateUI);
    }

    private void OnTranslateUI()
    {
        tmp_text_title.text = MMA.Localization.Service.Translate(Data_Localization.Key.setup_title);
        tmp_text_input_name_placeholder.text = MMA.Localization.Service.Translate(Data_Localization.Key.setup_input_name_placeholder);
        tmp_text_button_continue.text = MMA.Localization.Service.Translate(Data_Localization.Key.setup_continue);
    }
}
