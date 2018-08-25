using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class menu : MonoBehaviour
{

    public List<Texture2D> icons = new List<Texture2D>();

    public Texture2D background;

    public List<Texture2D> reactions_type = new List<Texture2D>();

    public List<Texture2D> synthesis = new List<Texture2D>();
    public List<Texture2D> decomposition = new List<Texture2D>();
    public List<Texture2D> single_displacement = new List<Texture2D>();
    public List<Texture2D> double_displacement = new List<Texture2D>();

    public List<MovieTexture> videos = new List<MovieTexture>();
    public List<AudioClip> audios = new List<AudioClip>();
    public Texture2D back_button;
    #region menu_bools
    bool is_show_menu = true;
    bool is_show_visualisations = false;
    bool is_show_theory = false;
    bool is_show_video = false;
    bool is_show_about = false;
    bool is_show_synthesis = false;
    bool is_show_decomposition = false;
    bool is_show_single_displacement = false;
    bool is_show_double_displacement = false;
    #endregion

    int current_video = 0;

    public Vector2 scroll;
    public GUISkin style;

    void OnGUI()
    {
        GUI.skin = style;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background, ScaleMode.ScaleAndCrop, false, 0);
        if (is_show_menu)
        {
            GUILayout.BeginArea(new Rect(100, Screen.height / 2 - 50, Screen.width - 100, 500));

            GUILayout.BeginHorizontal();

            if (GUILayout.Button(icons[0], GUILayout.Width(icons[0].width / 4), GUILayout.Height(icons[0].height / 4)))
            {
                is_show_menu = false;
                is_show_visualisations = true;
            }
            GUILayout.FlexibleSpace();

            if (GUILayout.Button(icons[1], GUILayout.Width(icons[1].width / 4), GUILayout.Height(icons[1].height / 4)))
            {
                is_show_menu = false;
                is_show_theory = true;
            }

            GUILayout.FlexibleSpace();

            if (GUILayout.Button(icons[2], GUILayout.Width(icons[2].width / 4), GUILayout.Height(icons[2].height / 4)))
            {
                is_show_menu = false;
                is_show_video = true;
            }

            GUILayout.FlexibleSpace();

            if (GUILayout.Button(icons[3], GUILayout.Width(icons[3].width / 4), GUILayout.Height(icons[3].height / 4)))
            {
                is_show_menu = false;
                is_show_about = true;
            }

            GUILayout.FlexibleSpace();

            if (GUILayout.Button(icons[4], GUILayout.Width(icons[4].width / 4), GUILayout.Height(icons[4].height / 4)))
            {
                Application.Quit();
            }

            GUILayout.FlexibleSpace();


            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }

        if (is_show_visualisations)
        {
            GUILayout.BeginArea(new Rect(100, Screen.height / 2 - 50, Screen.width - 100, 500));

            GUILayout.BeginHorizontal();

            if (GUILayout.Button(reactions_type[0], GUILayout.Width(reactions_type[0].width / 4), GUILayout.Height(reactions_type[0].height / 4)))
            {
                is_show_visualisations = false;
                is_show_synthesis = true;
            }
            GUILayout.FlexibleSpace();

            if (GUILayout.Button(reactions_type[1], GUILayout.Width(reactions_type[1].width / 4), GUILayout.Height(reactions_type[1].height / 4)))
            {
                is_show_visualisations = false;
                is_show_decomposition = true;
            }

            GUILayout.FlexibleSpace();

            if (GUILayout.Button(reactions_type[2], GUILayout.Width(reactions_type[2].width / 4), GUILayout.Height(reactions_type[2].height / 4)))
            {
                is_show_visualisations = false;
                is_show_single_displacement = true;
            }

            GUILayout.FlexibleSpace();

            if (GUILayout.Button(reactions_type[3], GUILayout.Width(reactions_type[3].width / 4), GUILayout.Height(reactions_type[3].height / 4)))
            {
                is_show_visualisations = false;
                is_show_double_displacement = true;
            }

            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(0, 0, 128, 128));
            GUILayout.BeginHorizontal();

            if (GUILayout.Button(back_button, GUILayout.Width(back_button.width / 4), GUILayout.Height(back_button.height / 4)))
            {
                is_show_visualisations = false;
                is_show_menu = true;
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }
        if (is_show_synthesis)
        {
            GUILayout.BeginArea(new Rect(100, Screen.height / 2 - 50, Screen.width - 100, 500));

            GUILayout.BeginHorizontal();

            for (int i = 0; i < synthesis.Count; i++)
            {
                if (GUILayout.Button(synthesis[i], GUILayout.Width(synthesis[i].width / 4), GUILayout.Height(synthesis[i].height / 4)))
                {
                    Application.LoadLevel(i + 1);
                }
                GUILayout.FlexibleSpace();
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(0, 0, 128, 128));
            GUILayout.BeginHorizontal();

            if (GUILayout.Button(back_button, GUILayout.Width(back_button.width / 4), GUILayout.Height(back_button.height / 4)))
            {
                is_show_visualisations = true;
                is_show_synthesis = false;
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }

        if (is_show_decomposition)
        {
            GUILayout.BeginArea(new Rect(100, Screen.height / 2 - 50, Screen.width - 100, 500));

            GUILayout.BeginHorizontal();

            for (int i = 0; i < decomposition.Count; i++)
            {
                if (GUILayout.Button(decomposition[i], GUILayout.Width(decomposition[i].width / 4), GUILayout.Height(decomposition[i].height / 4)))
                {
                    Application.LoadLevel(i + synthesis.Count + 1);
                }
                GUILayout.FlexibleSpace();
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(0, 0, 128, 128));
            GUILayout.BeginHorizontal();

            if (GUILayout.Button(back_button, GUILayout.Width(back_button.width / 4), GUILayout.Height(back_button.height / 4)))
            {
                is_show_visualisations = true;
                is_show_decomposition = false;
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }

        if (is_show_single_displacement)
        {
            GUILayout.BeginArea(new Rect(100, Screen.height / 2 - 50, Screen.width - 100, 500));

            GUILayout.BeginHorizontal();

            for (int i = 0; i < single_displacement.Count; i++)
            {
                if (GUILayout.Button(single_displacement[i], GUILayout.Width(single_displacement[i].width / 4), GUILayout.Height(single_displacement[i].height / 4)))
                {
                    Application.LoadLevel(i + synthesis.Count + decomposition.Count + 1);
                }
                GUILayout.FlexibleSpace();
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(0, 0, 128, 128));
            GUILayout.BeginHorizontal();

            if (GUILayout.Button(back_button, GUILayout.Width(back_button.width / 4), GUILayout.Height(back_button.height / 4)))
            {
                is_show_visualisations = true;
                is_show_single_displacement = false;
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }

        if (is_show_double_displacement)
        {
            GUILayout.BeginArea(new Rect(100, Screen.height / 2 - 50, Screen.width - 100, 500));

            GUILayout.BeginHorizontal();

            for (int i = 0; i < double_displacement.Count; i++)
            {
                if (GUILayout.Button(double_displacement[i], GUILayout.Width(double_displacement[i].width / 4), GUILayout.Height(double_displacement[i].height / 4)))
                {
                    Application.LoadLevel(i + synthesis.Count + decomposition.Count + single_displacement.Count + 1);
                }
                GUILayout.FlexibleSpace();
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(0, 0, 128, 128));
            GUILayout.BeginHorizontal();

            if (GUILayout.Button(back_button, GUILayout.Width(back_button.width / 4), GUILayout.Height(back_button.height / 4)))
            {
                is_show_visualisations = true;
                is_show_double_displacement = false;
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }
        if (is_show_video)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), videos[current_video], ScaleMode.ScaleAndCrop);
            GUILayout.BeginArea(new Rect(50, Screen.height - 100, Screen.width, 100));
            GUILayout.BeginHorizontal();


            if (GUILayout.Button("Старт", GUILayout.Height(100), GUILayout.Width(150)) && videos[current_video].isReadyToPlay)
            {
                videos[current_video].Play();
                GetComponent<AudioSource>().clip = audios[current_video];
                GetComponent<AudioSource>().Play();
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Пауза", GUILayout.Height(100), GUILayout.Width(150)) && videos[current_video].isReadyToPlay)
            {
                videos[current_video].Pause();
                GetComponent<AudioSource>().Pause();
            }
            GUILayout.FlexibleSpace();

            if (GUILayout.Button("Стоп", GUILayout.Height(100), GUILayout.Width(150)) && videos[current_video].isReadyToPlay)
            {
                videos[current_video].Stop();
                GetComponent<AudioSource>().Stop();
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Предыдущее видео", GUILayout.Height(100), GUILayout.Width(150)) && current_video > 1)
            {
                videos[current_video].Stop();
                current_video--;
                GetComponent<AudioSource>().clip = audios[current_video];
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Следующее видео", GUILayout.Height(100), GUILayout.Width(150)) && current_video < videos.Count - 1)
            {
                videos[current_video].Stop();
                
                current_video++;
                
                GetComponent<AudioSource>().clip = audios[current_video];
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();
            GUILayout.BeginArea(new Rect(0, 0, 128, 128));
            GUILayout.BeginHorizontal();

            if (GUILayout.Button(back_button, GUILayout.Width(back_button.width / 4), GUILayout.Height(back_button.height / 4)))
            {
                is_show_menu = true;
                is_show_video = false;
                
                videos[current_video].Stop();
                GetComponent<AudioSource>().Stop();
                current_video = 0;
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }
        if (is_show_theory)
        {
            GUILayout.BeginArea(new Rect(0, 128, Screen.width, Screen.height - 128));
            GUILayout.BeginHorizontal();


            scroll = GUILayout.BeginScrollView(scroll, true, true, GUILayout.Height(Screen.height - 128));
            GUILayout.Label("<size=30>Химическая реакция</size>\nХимическая реакция — превращение одного или нескольких исходных веществ (реагентов) в отличающиеся от них по химическому составу или строению вещества (продукты реакции), сопровождающееся разрывом и/или образованием химических связей. В отличие от ядерных реакций, при химических реакциях ядра атомов не меняются, в частности не изменяется их общее число, изотопный состав химических элементов, при этом происходит перераспределение электронов и ядер и образуются новые химические вещества.\nХимические реакции происходят при смешении или физическом контакте реагентов самопроизвольно, при нагревании, участии катализаторов (катализ), действии света (фотохимические реакции), электрического тока (электродные процессы), ионизирующих излучений (радиационно-химические реакции), механического воздействия (механохимические реакции), в низкотемпературной плазме (плазмохимические реакции) и т. п. Взаимодействие молекул между собой происходит по цепному маршруту: ассоциация — электронная изомеризация — диссоциация, в котором активными частицами являются радикалы, ионы, координационно-ненасыщенные соединения. Скорость химической реакции определяется концентрацией активных частиц и разницей между энергиями связи разрываемой и образуемой.\n<size=30>Классификация</size>\n Существует большое количество признаков, по которым можно классифицировать химические реакции.\n<size=26><color=gray>По фазовому составу реагирующей системы</color></size>\n1) Химическая реакция, протекающая в пределах одной фазы, называется гомогенной химической реакцией. Химическая реакция, протекающая на границе раздела фаз, называется гетерогенной химической реакцией. В многостадийной химической реакции некоторые стадии могут быть гомогенными, а другие — гетерогенными. Такие реакции называются гомогенно-гетерогенными.\n\nВ зависимости числа фаз, которые образуют исходные вещества и продукты реакции, химические процессы могут быть гомофазными (исходные вещества и продукты находятся в пределах одной фазы) и гетерофазными (исходные вещества и продукты образуют несколько фаз). Гомо- и гетерофазность реакции не связана с тем, является ли реакция гомо- или гетерогенной. Поэтому можно выделить четыре типа процессов:\nГомогенные гомофазные реакции. В реакциях такого типа реакционная смесь является гомогенной, а реагенты и продукты принадлежат одной и той же фазе. Примером таких реакций могут служить реакции ионного обмена, например, нейтрализация кислоты и щелочи в растворе:NaOH(раств.) + HCl(раств.) → NaCl(раств.) + H2O(ж.);\nГетерогенные гомофазные реакции. Компоненты находятся в пределах одной фазы, однако реакция протекает на границе раздела фаз, например, на поверхности катализатора. Примером может быть гидрирование этилена на никелевом катализаторе:C2H4(газ) + H2(газ) → C2H6(газ);\nГомогенные гетерофазные реакции. Реагенты и продукты в такой реакции существуют в пределах нескольких фаз, однако реакция протекает в одной фазе. Так может проходить окисление углеводородов в жидкой фазе газообразным кислородом.\nГетерогенные гетерофазные реакции. В этом случае реагенты находятся в разном фазовом состоянии, продукты реакции также могут находиться в любом фазовом состоянии. Реакционный процесс протекает на границе раздела фаз. Примером может служить реакция солей угольной кислоты (карбонатов) с кислотами Бренстеда:MgCO3(тв.) + 2 HCl(раств.) → MgCl2(раств.) + CO2(газ) + H2O(ж.)\n\n<size=26><color=gray>По изменению степеней окисления реагентов</color></size>\nВ данном случае различают\nОкислительно-восстановительные реакции, в которых атомы одного элемента (окислителя) восстанавливаются, то есть понижают свою степень окисления, а атомы другого элемента (восстановителя) окисляются, то есть повышают свою степень окисления. Частным случаем окислительно-восстановительных реакций являются реакции конпропорционирования, в которых окислителем и восстановителем являются атомы одного и того же элемента, находящиеся в разных степенях окисления.\nПример окислительно-восстановительной реакции — горение водорода (восстановитель) в кислороде (окислитель) с образованием воды:\n2 H2 + O2 = 2 H2O\nПример реакции конпропорционирования — реакция разложения нитрата аммония при нагревании. Окислителем в данном случае выступает азот (+5) нитрогруппы, а восстановителем — азот (-3) катиона аммония:\nNH4NO3 = N2O + 2 H2O (до 250 °C)\nНе относятся к окислительно-восстановительным реакции, в которых не происходит изменения степеней окисления атомов, например, BaCl2 + Na2SO4 = 2 NaCl + BaSO4(осадок)\n\n<size=26><color=gray>По тепловому эффекту реакции</color></size>\nВсе химические реакции сопровождаются выделением или поглощением энергии. При разрыве химических связей в реагентах выделяется энергия, которая в основном идёт на образование новых химических связей. В некоторых реакциях энергии этих процессов близки, и в таком случае общий тепловой эффект реакции приближается к нулю. В остальных случаях можно выделить:\nэкзотермические реакции, которые идут с выделением тепла, (положительный тепловой эффект) например, указанное выше горение водорода\nэндотермические реакции в ходе которых тепло поглощается (отрицательный тепловой эффект) из окружающей среды.\nТепловой эффект реакции (энтальпию реакции, ΔrH), часто имеющий очень важное значение, можно вычислить по закону Гесса, если известны энтальпии образования реагентов и продуктов. Когда сумма энтальпий продуктов меньше суммы энтальпий реагентов (ΔrH < 0) наблюдается выделение тепла, в противном случае (ΔrH > 0) — поглощение.\n\n");
            GUILayout.EndScrollView();


            GUILayout.EndHorizontal();
            GUILayout.EndArea();
            GUILayout.BeginArea(new Rect(0, 0, 128, 128));
            GUILayout.BeginHorizontal();

            if (GUILayout.Button(back_button, GUILayout.Width(back_button.width / 4), GUILayout.Height(back_button.height / 4)))
            {
                is_show_menu = true;
                is_show_theory = false;
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }
        if (is_show_about)
        {
            GUILayout.BeginArea(new Rect(0, 128, Screen.width, Screen.height - 128));
            GUILayout.BeginHorizontal();


            scroll = GUILayout.BeginScrollView(scroll, true, true, GUILayout.Height(Screen.height - 128));
            GUILayout.Label("<size=40><color=gray>Данная программа создана Илькином Мусаевым, учеником лицея им. Зарифа Алиевой.</color></size>\n\n\n\n<size=30><color=yellow>Управление</color></size>\n<color=yellow>Для выбора режима визуализации вам достаточно нажать на первую иконку в главном меню, далее выбрать интересующую вас визуализацию.\n\nУправление в режими визуализации</color>\nДля того, что бы начать симуляцию нажмите кнопку старт. Для перезапуска текущей симуляции нажмите кнопку стоп. Для выхода в главное меню нажмите соответсвующюю кнопку.\nДля приближения изпользуйте колесико мышки.\nДля того, что бы узнать название текущего элемента нажмите на данный эелемент левой кнопкой мыши.\n\n");
            GUILayout.EndScrollView();


            GUILayout.EndHorizontal();
            GUILayout.EndArea();
            GUILayout.BeginArea(new Rect(0, 0, 128, 128));
            GUILayout.BeginHorizontal();

            if (GUILayout.Button(back_button, GUILayout.Width(back_button.width / 4), GUILayout.Height(back_button.height / 4)))
            {
                is_show_menu = true;
                is_show_about = false;
            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }
    }
}
