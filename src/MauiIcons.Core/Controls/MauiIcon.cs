﻿using MauiIcons.Core.Converters;
using MauiIcons.Core.Helpers;
using Microsoft.Maui.Graphics.Converters;

namespace MauiIcons.Core;
public sealed class MauiIcon : ContentView, IMauiIcon
{
    public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(Enum), typeof(MauiIcon), null);
    public static readonly BindableProperty IconSizeProperty = BindableProperty.Create(nameof(IconSize), typeof(double), typeof(MauiIcon), 30.0);
    public static readonly BindableProperty IconColorProperty = BindableProperty.Create(nameof(IconColor), typeof(Color), typeof(MauiIcon), null);
    public static readonly BindableProperty IconBackgroundColorProperty = BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(MauiIcon), null);
    public static readonly BindableProperty IconAutoScalingProperty = BindableProperty.Create(nameof(IconAutoScaling), typeof(bool), typeof(MauiIcon), false);
    public static readonly BindableProperty IconSuffixProperty = BindableProperty.Create(nameof(IconSuffix), typeof(string), typeof(MauiIcon), null);
    public static readonly BindableProperty IconSuffixFontFamilyProperty = BindableProperty.Create(nameof(IconSuffixFontFamily), typeof(string), typeof(MauiIcon), null);
    public static readonly BindableProperty IconSuffixFontSizeProperty = BindableProperty.Create(nameof(IconSuffixFontSize), typeof(double), typeof(MauiIcon), 20.0);
    public static readonly BindableProperty IconSuffixTextColorProperty = BindableProperty.Create(nameof(IconSuffixTextColor), typeof(Color), typeof(MauiIcon), null);
    public static readonly BindableProperty IconSuffixBackgroundColorProperty = BindableProperty.Create(nameof(IconSuffixBackgroundColor), typeof(Color), typeof(MauiIcon), null);
    public static readonly BindableProperty IconAndSuffixBackgroundColorProperty = BindableProperty.Create(nameof(IconAndSuffixBackgroundColor), typeof(Color), typeof(MauiIcon));
    public static readonly BindableProperty IconSuffixAutoScalingProperty = BindableProperty.Create(nameof(IconSuffixAutoScaling), typeof(bool), typeof(MauiIcon), false);
    public static readonly BindableProperty EntranceAnimationTypeProperty = BindableProperty.Create(nameof(EntranceAnimationType), typeof(AnimationType), typeof(MauiIcon), AnimationType.None);
    public static readonly BindableProperty EntranceAnimationDurationProperty = BindableProperty.Create(nameof(EntranceAnimationDuration), typeof(uint), typeof(MauiIcon), (uint)1500);
    public static readonly BindableProperty OnPlatformProperty = BindableProperty.Create(nameof(OnPlatform), typeof(PlatformType), typeof(MauiIcon), PlatformType.All);
    public static readonly BindableProperty OnIdiomProperty = BindableProperty.Create(nameof(OnIdiom), typeof(PlatformType), typeof(MauiIcon), PlatformType.All);
    public static readonly BindableProperty OnPlatformsProperty = BindableProperty.Create(nameof(OnPlatforms), typeof(IList<string>), typeof(MauiIcon), null);
    public static readonly BindableProperty OnIdiomsProperty = BindableProperty.Create(nameof(OnIdioms), typeof(IList<string>), typeof(MauiIcon), null);


#nullable enable
    public Enum? Icon
    {
        get => (Enum?)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
#nullable disable

    [System.ComponentModel.TypeConverter(typeof(FontSizeConverter))]
    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }

    [System.ComponentModel.TypeConverter(typeof(ColorTypeConverter))]
    public Color IconColor
    {
        get => (Color)GetValue(IconColorProperty);
        set => SetValue(IconColorProperty, value);
    }

    [System.ComponentModel.TypeConverter(typeof(ColorTypeConverter))]
    public Color IconBackgroundColor
    {
        get => (Color)GetValue(IconBackgroundColorProperty);
        set => SetValue(IconBackgroundColorProperty, value);
    }
    public bool IconAutoScaling
    {
        get => (bool)GetValue(IconAutoScalingProperty);
        set => SetValue(IconAutoScalingProperty, value);
    }
    public string IconSuffix
    {
        get => (string)GetValue(IconSuffixProperty);
        set => SetValue(IconSuffixProperty, value);
    }

    public string IconSuffixFontFamily
    {
        get => (string)GetValue(IconSuffixFontFamilyProperty);
        set => SetValue(IconSuffixFontFamilyProperty, value);
    }

    [System.ComponentModel.TypeConverter(typeof(FontSizeConverter))]
    public double IconSuffixFontSize
    {
        get => (double)GetValue(IconSuffixFontSizeProperty);
        set => SetValue(IconSuffixFontSizeProperty, value);
    }

    [System.ComponentModel.TypeConverter(typeof(ColorTypeConverter))]
    public Color IconSuffixTextColor
    {
        get => (Color)GetValue(IconSuffixTextColorProperty);
        set => SetValue(IconSuffixTextColorProperty, value);
    }

    [System.ComponentModel.TypeConverter(typeof(ColorTypeConverter))]
    public Color IconSuffixBackgroundColor
    {
        get => (Color)GetValue(IconSuffixBackgroundColorProperty);
        set => SetValue(IconSuffixBackgroundColorProperty, value);
    }

    [System.ComponentModel.TypeConverter(typeof(ColorTypeConverter))]
    public Color IconAndSuffixBackgroundColor
    {
        get => (Color)GetValue(IconAndSuffixBackgroundColorProperty);
        set => SetValue(IconAndSuffixBackgroundColorProperty, value);
    }

    public bool IconSuffixAutoScaling
    {
        get => (bool)GetValue(IconSuffixAutoScalingProperty);
        set => SetValue(IconSuffixAutoScalingProperty, value);
    }

    public AnimationType EntranceAnimationType
    {
        get => (AnimationType)GetValue(EntranceAnimationTypeProperty);
        set => SetValue(EntranceAnimationTypeProperty, value);
    }
    public uint EntranceAnimationDuration
    {
        get => (uint)GetValue(EntranceAnimationDurationProperty);
        set => SetValue(EntranceAnimationDurationProperty, value);
    }
    public PlatformType OnPlatform
    {
        get => (PlatformType)GetValue(OnPlatformProperty);
        set => SetValue(OnPlatformProperty, value);
    }
    public IdiomType OnIdiom
    {
        get => (IdiomType)GetValue(OnIdiomProperty);
        set => SetValue(OnIdiomProperty, value);
    }

    [System.ComponentModel.TypeConverter(typeof(ListStringTypeConverter))]
    public IList<string> OnPlatforms
    {
        get => (IList<string>)GetValue(OnPlatformsProperty);
        set => SetValue(OnPlatformsProperty, value);
    }

    [System.ComponentModel.TypeConverter(typeof(ListStringTypeConverter))]
    public IList<string> OnIdioms
    {
        get => (IList<string>)GetValue(OnIdiomsProperty);
        set => SetValue(OnIdiomsProperty, value);
    }

    public MauiIcon()
    {
        Content = BuildIconControl();
        Loaded += async (s, r) =>
        {
            RemoveContentBasedOnPlatformAndIdiom();
            iconSpan.FontFamily = Icon.GetFontFamily();
            await AnimateIcon(rootLabel);
        };
    }

    Label rootLabel;
    Span iconSpan;
    Span suffixSpan;
    private Label BuildIconControl()
    {
        iconSpan = new();
        iconSpan.SetBinding(Span.TextProperty, new Binding(nameof(Icon), converter: new EnumToStringConverter(), source: this));
        iconSpan.SetBinding(Span.FontAutoScalingEnabledProperty, new Binding(nameof(IconAutoScaling), source: this));
        iconSpan.SetBinding(Span.FontSizeProperty, new Binding(nameof(IconSize), source: this));
        iconSpan.SetBinding(Span.TextColorProperty, new Binding(nameof(IconColor), source: this));
        iconSpan.SetBinding(Span.BackgroundColorProperty, new Binding(nameof(IconBackgroundColor), source: this));

        suffixSpan = new();
        suffixSpan.SetBinding(Span.TextProperty, new Binding(nameof(IconSuffix), source: this));
        suffixSpan.SetBinding(Span.FontAutoScalingEnabledProperty, new Binding(nameof(IconSuffixAutoScaling), source: this));
        suffixSpan.SetBinding(Span.FontSizeProperty, new Binding(nameof(IconSuffixFontSize), source: this));
        suffixSpan.SetBinding(Span.FontFamilyProperty, new Binding(nameof(IconSuffixFontFamily), source: this));
        suffixSpan.SetBinding(Span.TextColorProperty, new Binding(nameof(IconSuffixTextColor), source: this));
        suffixSpan.SetBinding(Span.BackgroundColorProperty, new Binding(nameof(IconSuffixBackgroundColor), source: this));

        rootLabel = new();
        rootLabel.SetBinding(Label.BackgroundColorProperty, new Binding(nameof(IconAndSuffixBackgroundColor), source: this));
        rootLabel.FormattedText = new FormattedString();
        rootLabel.FormattedText.Spans.Add(iconSpan);
        rootLabel.FormattedText.Spans.Add(new Span { Text = " " });
        rootLabel.FormattedText.Spans.Add(suffixSpan);
        return rootLabel;
    }

    async Task AnimateIcon(Label label)
    {
        switch (EntranceAnimationType)
        {
            case AnimationType.None:
                return;
            case AnimationType.Fade:
                label.Opacity = 0;
                await label.FadeTo(1, EntranceAnimationDuration);
                return;
            case AnimationType.Scale:
                await label.ScaleTo(1.5, EntranceAnimationDuration);
                await label.ScaleTo(1, EntranceAnimationDuration);
                return;
            case AnimationType.Rotate:
                await label.RotateTo(360, EntranceAnimationDuration);
                label.Rotation = 0;
                return;
        }
    }

    public static explicit operator Image(MauiIcon baseIcon) => new()
    {
        Source = new FontImageSource()
        {
            Glyph = baseIcon.Icon.GetDescription(),
            Color = baseIcon.IconColor.SetDefaultOrAssignedColor(),
            FontFamily = baseIcon.Icon.GetFontFamily(),
            Size = baseIcon.IconSize,
            FontAutoScalingEnabled = baseIcon.IconAutoScaling,
        },
        BackgroundColor = baseIcon.IconBackgroundColor,
    };

    public static explicit operator FontImageSource(MauiIcon mi) => new()
    {
        Glyph = mi.Icon.GetDescription(),
        Color = mi.IconColor.SetDefaultOrAssignedColor(),
        FontFamily = mi.Icon.GetFontFamily(),
        Size = mi.IconSize,
        FontAutoScalingEnabled = mi.IconAutoScaling,
    };

    public static explicit operator Label(MauiIcon mi)
    {
        var label = mi.rootLabel;
        mi.iconSpan.FontFamily = mi.Icon.GetFontFamily();
        label.Loaded += async (s, r) =>
        {
            await mi.AnimateIcon(label);
        };
        return label;
    }

    public static explicit operator Button(MauiIcon mi)
    {
        var button = new Button
        {
            Text = mi.Icon.GetDescription(),
            FontFamily = mi.Icon.GetFontFamily(),
            FontSize = mi.IconSize,
            FontAutoScalingEnabled = mi.IconAutoScaling
        };
        button.TextColor = mi.IconColor.SetDefaultOrAssignedColor(button.TextColor);
        button.BackgroundColor = mi.IconBackgroundColor.SetDefaultOrAssignedColor(button.BackgroundColor);
        return button;
    }

    void RemoveContentBasedOnPlatformAndIdiom()
    {
        if (!PlatformHelper.IsValidPlatformAndIdiom(OnPlatform, OnIdiom))
            Content = null;

        return;
    }

}
