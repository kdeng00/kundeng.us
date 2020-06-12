from django.http import HttpResponse
from django.shortcuts import render

def test(request):
    return render(request, 'website/test.html')

def home(request):
    return render(request, 'website/home.html')
