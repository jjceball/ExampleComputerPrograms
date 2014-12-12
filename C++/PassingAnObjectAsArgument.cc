#include <iostream.h>

struct Paper

{

	double Width;

	double Height;

};



void MagazineCover(Paper ppr)

{

    cout << "Characteristics of this piece of paper";

    cout << "\nWidth     = " << ppr.Width;

    cout << "\nHeight    = " << ppr.Height;

    cout << "\nPerimeter = " << 2 + (ppr.Width + ppr.Height);

    cout << "\nArea      = " << ppr.Width * ppr.Height;

}



int main(int argc, char* argv[])

{

    double w, h;



    cout << "Provide the dimensions of the magazine cover\n";

    cout << "Width: ";

    cin >> w;

    cout << "Height: ";

    cin >> h;



    Paper Cover = {w, h};

    MagazineCover(Cover);



    getchar();

    return 0;

}