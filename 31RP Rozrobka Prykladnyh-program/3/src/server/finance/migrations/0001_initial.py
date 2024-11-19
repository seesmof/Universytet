# Generated by Django 5.1.3 on 2024-11-19 13:32

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Client',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=127)),
                ('balance', models.PositiveIntegerField(default=0)),
                ('credit', models.PositiveIntegerField(default=0)),
            ],
        ),
    ]
