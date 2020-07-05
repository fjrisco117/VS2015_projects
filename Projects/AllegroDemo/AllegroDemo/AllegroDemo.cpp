// AllegroDemo.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <allegro5/allegro.h>
#include <allegro5/allegro_font.h>
#include <allegro5/allegro_ttf.h>

int main()
{
	al_init(); //all allegro libraries calls begin with this statement, otherwise you will get an exception
	al_init_font_addon();
	al_init_ttf_addon();

	ALLEGRO_DISPLAY * display = al_create_display(640, 480);
	ALLEGRO_FONT * font = al_load_ttf_font("YARDSALE.ttf", 64, 0);

	while (true) {
		al_clear_to_color(al_map_rgb(255, 255, 255));
		al_draw_text(font, al_map_rgb(0, 0, 0), 0, 0, 0, "Hello World!");
		al_flip_display();
	}

	al_destroy_display(display);
	al_destroy_font(font);
    return 0;
}

