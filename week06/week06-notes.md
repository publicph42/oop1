# Week 6 notes

## 4 pillars of oop

- encapsulation
  - getter and setters
  - erisim denetleyiceler
    - public
    - private
    - protected: an object can access the values that was inherited from it's
    parent objects
    - internal: project wide access
- inheritence
- polymorphism

## Constructor

Bir nesne ilk kez olusurken calisir.

- Sinif adi ile ayni olur
- Geri donus tipi alamaz, geri donus yapamaz
- Sadece new ile obje olusurken bir kez calisir

## public Student(string ad, int numara) : this(ad, numara, "Bolumu belirsiz")

public Student(string ad, int numara, string bolum)
in the code snippet above, we have a class constructor called Student and
we have an overloading of that constructor.
but we can give a default value using `: this(ad, numara, (Defeault Value)`

### How does that work?

when there is a : this (....) in front a constructor. it takes the values it got
and calls another constructor method. in our codebase that is
another constructor that takes 3 values.
and we passed a default string for the third arguemant.

## Sinavda Cikabilir

The order of methods are being called could be on the exam. check the code and
run to understand everything
